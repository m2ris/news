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
    /// Interaction logic for PickerControl.xaml
    /// </summary>
    public partial class PickerControl : UserControl
    {
        #region Selected DP
        public object Selected
        {
            get { return (object)GetValue(SelectedProperty); }
            set { SetValue(SelectedProperty, value);  }
        }
        public static readonly DependencyProperty SelectedProperty = 
            DependencyProperty.Register("Selected", typeof(object), 
                typeof(PickerControl), new PropertyMetadata(null));
        # endregion
        public PickerControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }
        public void lbStories_selChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
