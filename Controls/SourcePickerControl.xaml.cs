using News.data;
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
    /// Interaction logic for SourcePickerControl.xaml
    /// </summary>
    public partial class SourcePickerControl : UserControl
    {
        #region DataSource DP
        public StoriesService DataSource
        {
            get { return (StoriesService)GetValue(StoriesServiceProperty); }
            set { SetValue(StoriesServiceProperty, value); }
        }
        public static readonly DependencyProperty StoriesServiceProperty =
            DependencyProperty.Register("DataSource", typeof(StoriesService),
              typeof(SourcePickerControl), new PropertyMetadata(null));

        #endregion

        public SourcePickerControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }

        private void Delfi_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DataSource = new DelfiStoriesService();
        }

        private void Err_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DataSource = new ErrStoriesService();
        }

        private void Postimees_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DataSource = new PostimeesStoriesService();
        }
    }
}
