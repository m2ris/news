using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace News.model
{
    public class Story : INotifyPropertyChanged
    {
        private String _title;

        public String Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }

        }
        private String _content;

        public String Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }

        }
        private DateTime _date;

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }

        }

        private ImageSource _picture;

        public ImageSource Picture
        {
            get
            {
                return _picture;
            }

            set
            {
                _picture = value;
                OnPropertyChanged("Picture");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
