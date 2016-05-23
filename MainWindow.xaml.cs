using News.data;
using News.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace News
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }

        private void Delfi_MouseUp(object sender, MouseButtonEventArgs e)
        {
            getVM().StoriesService = new DelfiStoriesService();
        }

        private void Err_MouseUp(object sender, MouseButtonEventArgs e)
        {
            getVM().StoriesService = new ErrStoriesService();
        }

        private void Postimees_MouseUp(object sender, MouseButtonEventArgs e)
        {
            getVM().StoriesService = new PostimeesStoriesService();
        }

        private MainWindowVM getVM()
        {
            return DataContext as MainWindowVM;
        }
    }
}
