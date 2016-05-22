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
        #region Title DP
        public String Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string),
              typeof(StoryControl), new PropertyMetadata(null));

        #endregion
        #region Description DP
        public String Description
        {
            get { return (String)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string),
              typeof(StoryControl), new PropertyMetadata(null));

        #endregion
        #region Date DP
        public String Date
        {
            get { return (String)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }
        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(string),
              typeof(StoryControl), new PropertyMetadata(null));

        #endregion
        #region Author DP
        public String Author
        {
            get { return (String)GetValue(AuthorProperty); }
            set { SetValue(AuthorProperty, value); }
        }
        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author", typeof(string),
              typeof(StoryControl), new PropertyMetadata(null));

        #endregion
        #region Picture DP
        public ImageSource Picture
        {
            get { return (ImageSource)GetValue(PictureProperty); }
            set { SetValue(PictureProperty, value); }
        }
        public static readonly DependencyProperty PictureProperty =
            DependencyProperty.Register("Picture", typeof(ImageSource),
              typeof(StoryControl), new PropertyMetadata(default(ImageSource)));

        #endregion
        public StoryControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }
    }
}
