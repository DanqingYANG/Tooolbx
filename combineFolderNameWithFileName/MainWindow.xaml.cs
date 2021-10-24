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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace combineFolderNameWithFileName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // It is already the nth time, when I left a comment and be blocked by the Tecent system.
    // Last time it was during some country government revolution... and it is said my network broke down but my network works.
    // The most interesting thing is I said nothing good or bad it is just a message that everybody get.
    // maybe the system is trying to tell me what I receive is not real.
    // the truth is someone did be the president after a period of time. 
    // 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel.viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
