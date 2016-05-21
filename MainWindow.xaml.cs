﻿using News.data;
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
        Story selectedStory;

        public MainWindow()
        {
            InitializeComponent();

            lbStories.ItemsSource = storiesService.loadStories();
        }

        public void lbStories_selChanged(object sender, RoutedEventArgs e)
        {
            selectedStory = lbStories.SelectedItem as Story;
            Console.WriteLine("selection changed: " + selectedStory.Content);

            tbAuthor.Text = selectedStory.Author;
            tbContent.Text = selectedStory.Content;
            tbTitle.Text = selectedStory.Title;
            tbDate.Text = selectedStory.Date;
            

            try
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                ImageSource src = converter.ConvertFromString(selectedStory.Picture) as ImageSource;
                iPicture.Source = src;
            }catch(NullReferenceException ex)
            {

            }
        }
    }
}
