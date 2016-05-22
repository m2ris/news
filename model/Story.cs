using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace News.model
{
    class Story
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

        public String Description
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
        private String _date;

        public String Date
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
        private String _author;
        public String Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }

        }
    }
}
