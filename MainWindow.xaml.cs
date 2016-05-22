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
        Story SelectedStory;

        public MainWindow()
        {
            InitializeComponent();

            lbStories.ItemsSource = storiesService.loadStories();
        }

        public void lbStories_selChanged(object sender, RoutedEventArgs e)
        {
            SelectedStory = lbStories.SelectedItem as Story;
            Console.WriteLine("selection changed: " + SelectedStory.Title);

            scStory.Story = SelectedStory;

            /*tbAuthor.Text = SelectedStory.Author;
            tbContent.Text = SelectedStory.Content;
            tbTitle.Text = SelectedStory.Title;
            tbDate.Text = SelectedStory.Date;
            iPicture.Source = SelectedStory.Picture;*/
        }
    }
}
