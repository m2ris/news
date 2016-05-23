using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.model
{
    public class MainWindowVM : BaseVM, INotifyPropertyChanged
    {
        private Story _selectedStory;
        public Story SelectedStory {
            get
            {
                return _selectedStory;
            }
            set
            {
                _selectedStory = value;
                OnPropertyChanged("SelectedStory");
            }
        }
    }
}
