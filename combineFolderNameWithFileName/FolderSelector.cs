﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combineFolderNameWithFileName
{
    class FolderSelector: INotifyPropertyChanged
    {
        public static Dictionary<string, FolderSelector> myParents = new Dictionary<string, FolderSelector>();

        public DirectoryInfo DirInfo { get; set; }
        
        public List<FolderSelector> Children { get; set; }
        public string Name { get; set; }

        public static bool SelectState;


        private bool? isChecked;
        public bool? IsChecked
        {
            get { return isChecked; }
            set
            {
                if(SelectState == true)
                {
                    isChecked = value;
                    NotifyPropertyChanged("IsChecked");
                }
                else
                {
                    SetIsChecked(value, true, true);
                }
            }
        }

        private void SetIsChecked(bool? checkStatus, bool updateChildren, bool updateParent)
        {
            if (checkStatus == isChecked) return;
            isChecked = checkStatus;
            if (updateChildren && isChecked.HasValue)
            {
                Children.ForEach(c => c.SetIsChecked(IsChecked, true, false));
            }
            if (updateParent && DirInfo.Parent.FullName != null && myParents.ContainsKey(DirInfo.Parent.FullName))
            {
                myParents[DirInfo.Parent.FullName].VerifyCheckedState();
            }
            NotifyPropertyChanged("IsChecked");
        }

        private void VerifyCheckedState()
        {
            bool? state = null;
            for(int i = 0; i < Children.Count; i++)
            {
                bool? curr = Children[i].IsChecked;
                if(i == 0)
                {
                    state = curr;
                }
                else if(state != curr)
                {
                    state = null;
                    break;
                }
            }
            SetIsChecked(state, false, true); // parent branch
        }

        #region
        // async test
        public void test()
        {
            var subdirs = DirInfo.GetDirectories();
            foreach (var dir in subdirs)
            {
                FolderSelector child = new FolderSelector(dir.FullName);
                myParents[child.DirInfo.FullName] = this;
                Children.Add(child);
            }
        }

        // async test1
        public void test1()
        {
            //IEnumerable<int> GenerateWithYield()
            //{
            //    var i = 0;
            //    while (i < 5)
            //    {
            //        yield return ++i;
            //        yield return i + 2;
            //    }
            //}

            //foreach (var number in GenerateWithYield())
            //    Console.WriteLine(number);
            var subdirs = DirInfo.GetDirectories();
            IEnumerable<int> GenerateWithYield()
            {
                yield return 1;
            }
            
            foreach (var dir in subdirs)
            {
                FolderSelector child = new FolderSelector(dir.FullName);
                myParents[child.DirInfo.FullName] = this;
                Children.Add(child);
            }
        }

        // async test2
        public void test2()
        {
            var subdirs = DirInfo.GetDirectories();
            foreach (var dir in subdirs)
            {
                FolderSelector child = new FolderSelector(dir.FullName);
                myParents[child.DirInfo.FullName] = this;
                Children.Add(child);
            }
        }

        #endregion

        public FolderSelector(string path)
        {
            DirInfo = new DirectoryInfo(path);
            Children = new List<FolderSelector>();
            Name = DirInfo.Name;
            // init
            isChecked = true; 
            SelectState = false;

            //test();
            //test1();
            //test2();
            
            return;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
