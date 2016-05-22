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
        StoriesService storiesService = new StoriesService();
        Story SelectedStory;

        public MainWindow()
        {
            InitializeComponent();

            //lbStories.ItemsSource = storiesService.loadStories();
            lbStories.ItemsSource = storiesService.LoadFromPostimees();
        }

        public void lbStories_selChanged(object sender, RoutedEventArgs e)
        {
            SelectedStory = lbStories.SelectedItem as Story;
            StoryControl.Story = SelectedStory;
            StoryControl2.Story = storiesService.LoadFromPostimees()[0];
            /*tbContent.Text = selectedStory.Content;
            tbTitle.Text = selectedStory.Title;
            tbDate.Text = selectedStory.Date.ToShortDateString();
            iPicture.Source = selectedStory.Picture;*/
        }
    }
}
