using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combineFolderNameWithFileName
{
    class EmptyFolderSelectorVM: INotifyPropertyChanged
    {
        public static EmptyFolderSelectorVM emptyFolderSelectorVM = new EmptyFolderSelectorVM();
        public String FolderPath = ViewModel.viewModel.SourceDir;
        public ObservableCollection<FolderSelector> FolderSelectors { get; set; }

        public FolderSelector folderSelector { get; set; }
        public List<string> SelectedFolderPaths = new List<string>();
        //public ObservableCollection<EmptyFolderSelectorVM> FolderSelectorVMs = new ObservableCollection<EmptyFolderSelectorVM>();

        public EmptyFolderSelectorVM()
        {
            FolderSelectors = new ObservableCollection<FolderSelector>();
            folderSelector = new FolderSelector(FolderPath);
            FolderSelectors.Add(folderSelector);

            onDefault = new RelayCommand(CheckDefault);
            OnCheckAll = new RelayCommand(CheckAll);
            OnUnCheckAll = new RelayCommand(UnCheckAll);
            OnRemove = new RelayCommand(RemoveSelectedFolders);
        }

        private string currState;
        public string CurrState
        {
            get { return currState; }
            set { currState = value; }
        }


        //public bool SetCheckBox(FolderSelector fs)
        //{
        //    switch (CurrState)
        //    {
        //        case "SelectAll":
        //            return true;
        //        case "SelectNone":
        //            return false;
        //        default:
        //            return (fs.DirInfo.GetFiles().Length == 0 ? true : false);
        //    }
        //}


        #region
        void RemoveSelectedFolders()
        {
            
            List<string> SelectedFolderPaths = new List<string>();
            List<FolderSelector> list = FolderSelectors.ToList();

            GetSelectedFolderFullPath(ref SelectedFolderPaths, list);
            //GetSelectedFolderFullPath(ref temp, FolderSelectorVMs);

            foreach (var fp in SelectedFolderPaths)
            {
                if(Directory.Exists(fp))
                {
                    Directory.Delete(fp);
                }
            }
            return;
        }


        //void GetSelectedFolderFullPath(ref List<string> container, ObservableCollection<EmptyFolderSelectorVM> folderSelectorVM)
        //{
        //    foreach (var fsvm in folderSelectorVM)
        //    {
        //        if (fsvm.FolderSelector.IsChecked == true)
        //        {
        //            container.Add(fsvm.FolderPath);
        //        }
        //        GetSelectedFolderFullPath(ref container, fsvm.FolderSelectorVMs);
        //    }
        //    return;
        //}


        void GetSelectedFolderFullPath(ref List<string> container, List<FolderSelector> folderSelector)
        {
            foreach (var fs in folderSelector)
            {
                if (fs.IsChecked == true)
                {
                    container.Add(fs.DirInfo.FullName);
                }
                GetSelectedFolderFullPath(ref container, fs.Children);
            }
            return;
        }

        void autoCheck(FolderSelector fs, bool? b)
        {
            fs.IsChecked = b;
            
            for (int i = 0; i < fs.Children.Count; i++)
            {
                autoCheck(fs.Children[i], b);
            }
        }

        bool checkEmptyFoldersOnly(FolderSelector fs)
        {
            bool containsFile = fs.DirInfo.GetFiles().Length > 0;
            if (fs.Children.Count != 0)            
            {
                // DFS 
                //containsFile |= fs.DirInfo.GetFiles().Length > 0;
                for (int i = 0; i < fs.Children.Count; ++i)
                {
                    var c = fs.Children[i];
                    containsFile |= checkEmptyFoldersOnly(c);
                }
            }
            fs.IsChecked = !containsFile;
            return containsFile;
        }
            
        void CheckDefault()
        {
            FolderSelector.SelectState = true;
            checkEmptyFoldersOnly(folderSelector);
            FolderSelector.SelectState = false;
        }

        void CheckAll()
        {
            autoCheck(folderSelector, true);
        }

        void UnCheckAll()
        {
            autoCheck(folderSelector, false);
        }

        #region RelayCommand
        private RelayCommand onCheckAll;

        public RelayCommand OnCheckAll
        {
            get { return onCheckAll; }
            set { onCheckAll = value; }
        }

        private RelayCommand onUnCheckAll;
            
        public RelayCommand OnUnCheckAll
        {
            get { return onUnCheckAll; }
            set { onUnCheckAll = value; }
        }

        private RelayCommand onRemove;

        public RelayCommand OnRemove
        {
            get { return onRemove; }
            set { onRemove = value; }
        }

        private RelayCommand onDefault;

        public RelayCommand OnDefault
        {
            get { return onDefault; }
            set { onDefault = value; }
        }
        #endregion

        #endregion


        public event PropertyChangedEventHandler PropertyChanged;
        internal void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
