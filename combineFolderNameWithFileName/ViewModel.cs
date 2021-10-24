using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combineFolderNameWithFileName
{
    public class ViewModel: INotifyPropertyChanged
    {
        public static ViewModel viewModel = new ViewModel();

        private string sourceDir;
        public string SourceDir
        {
            get { return sourceDir; }
            set
            {
                sourceDir = value;
                NotifyPropertyChanged("SourceDir");
            }
        }

        string[] Subfolders = { };

        // checkbox
        private bool removeAfterCopied;
        public bool RemoveAfterCopied
        {
            get { return removeAfterCopied; }
            set { removeAfterCopied = value;
                NotifyPropertyChanged("RemoveAfterCopied");
            }
        }

        // checkbox
        private bool removeEmptyFolders;
        public bool RemoveEmptyFolders
        {
            get { return removeEmptyFolders; }
            set
            {
                removeEmptyFolders = value;
                NotifyPropertyChanged("RemoveEmptyFolders");
            }
        }

        public ViewModel()
        {
            OnSelectFolder = new RelayCommand(OpenExplorer);
            OnMove = new RelayCommand(CopyFiles);
            removeAfterCopied = true;
            removeEmptyFolders = true;

            // test
            
        }

        #region
        private RelayCommand onSelectFolder;
        public RelayCommand OnSelectFolder
        {
            get { return onSelectFolder; }
            set { onSelectFolder = value; }
        }

        private RelayCommand onMove;
        public RelayCommand OnMove
        {
            get { return onMove; }
            set { onMove = value; }
        }

        public void OpenExplorer()
        {
            // get subfolders
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    SourceDir = folderBrowserDialog.SelectedPath;
                    //System.Windows.Forms.MessageBox.Show("Files found: " + subfolders.Length.ToString(), "Message");
                }
            }
            return;
        }

        

        public void CopyFiles()
        {
            EmptyFolderSelector emptyFolder = new EmptyFolderSelector();
            // get subfolders
            if (SourceDir == null || SourceDir == "")
                return;
            var Folders = Directory.GetDirectories(SourceDir);
            if (Folders==null)
                return;
            Subfolders = Folders;
            // copy each file out
            foreach (var folder in Subfolders)
            {
                // get pdf file 
                // var files = Directory.EnumerateFiles(folder, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".pdf"));
                string[] files = Directory.GetFiles(folder, "*.pdf");
                foreach (var f in files)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(folder.Length + 1);
                    string folderName = folder.Substring(sourceDir.Length+1);
                    // Use the Path.Combine method to safely append the file name to the path.
                    // Will overwrite if the destination file already exists.
                    File.Copy(f, Path.Combine(SourceDir, folderName+"-"+fName), true);
                }

                if (RemoveAfterCopied)
                {
                    foreach (string f in files)
                    {
                        File.Delete(f);
                    }

                    if (RemoveEmptyFolders)
                    {
                        emptyFolder.Show();
                    }
                }
            }
            return;
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        internal void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
