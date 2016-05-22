using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace News.model
{
    public class Story
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
            }

        }
    }
}
