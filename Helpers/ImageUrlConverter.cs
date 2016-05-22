using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace News.Helpers
{
    class ImageUrlConverter
    {
        public static ImageSource ToImageSource(string url)
        {
            if(url == null)
            {
                return null;
            }
            try
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                ImageSource src = converter.ConvertFromString(url) as ImageSource;
                return src;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
        }
    }
}
