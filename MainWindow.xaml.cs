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
        StoriesService storiesService = new PostimeesStoriesService();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
            ReloadStories();
        }

        public void lbStories_selChanged(object sender, RoutedEventArgs e)
        {
            //SelectedStory = lbStories.SelectedItem as Story;
            //scStory.Story = SelectedStory;
        }

        private void Delfi_MouseUp(object sender, MouseButtonEventArgs e)
        {
            storiesService = new DelfiStoriesService();
            ReloadStories();
        }

        private void Err_MouseUp(object sender, MouseButtonEventArgs e)
        {
            storiesService = new ErrStoriesService();
            ReloadStories();
        }
        private void Postimees_MouseUp(object sender, MouseButtonEventArgs e)
        {
            storiesService = new PostimeesStoriesService();
            ReloadStories();        
        }
        private void ReloadStories()
        {
            lbStories.ItemsSource = storiesService.loadStories();
        }
    }
}
