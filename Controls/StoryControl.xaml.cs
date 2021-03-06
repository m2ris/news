﻿using News.model;
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

namespace News.Controls
{
    /// <summary>
    /// Interaction logic for StoryControl.xaml
    /// magic gathered from: http://blog.scottlogic.com/2012/02/06/a-simple-pattern-for-creating-re-useable-usercontrols-in-wpf-silverlight.html
    /// </summary>
    public partial class StoryControl : UserControl
    {
        #region Story DP
        public Story Story
        {
            get { return (Story)GetValue(StoryProperty); }
            set { SetValue(StoryProperty, value); }
        }
        public static readonly DependencyProperty StoryProperty =
            DependencyProperty.Register("Story", typeof(Story),
              typeof(StoryControl), new PropertyMetadata(null));

        #endregion
        public StoryControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }
    }
}
