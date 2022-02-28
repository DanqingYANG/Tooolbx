using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace combineFolderNameWithFileName
{
    /// <summary>
    /// Interaction logic for EmptyFolderSelector.xaml
    /// </summary>
    public partial class EmptyFolderSelector : Window
    {
        public EmptyFolderSelector()
        {
            DataContext = EmptyFolderSelectorVM.emptyFolderSelectorVM;
            InitializeComponent();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //tv.ItemsSource = EmptyFolderSelectorVM.emptyFolderSelectorVM.FolderSelectors; // static method, ClassName.StaticMethod()
        //}
    }
}
