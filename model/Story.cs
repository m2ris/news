using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private String _picture;

        public String Picture
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
