using News.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml;

namespace News.data
{
    public class StoriesService
    {
        public ObservableCollection<Story> loadStories()
        {
            ObservableCollection<Story> stories = new ObservableCollection<Story>();
            stories.Add(new Story() {
                Title = "esimene",
                Content = "Lorizzle ipsum bling bling sit amizzle, consectetuer adipiscing elit.",
                Date = new DateTime(2016, 05, 21),
                Picture = toImgSource("http://www.microsoft.com/silverlight/images/ms-silverlight-logo.png")
            });
            stories.Add(new Story() {
                Title = "teine",
                Content = "Check it out hizzle that's the shizzle. We gonna chung erizzle.",
                Date = new DateTime(2016, 05, 21),
                Picture = toImgSource("http://www.microsoft.com/silverlight/images/ms-silverlight-logo.png")
            });
            return stories;
        }

        private ImageSource toImgSource(string val)
        {
            try
            {
                return new ImageSourceConverter().ConvertFromString(val) as ImageSource;
            }
            catch(NullReferenceException ex)
            {
                return null;
            }
        }

        public ObservableCollection<Story> LoadFromPostimees()
        {
            ObservableCollection<Story> stories = new ObservableCollection<Story>();

            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load("http://postimees.ee/rss");

            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            foreach (XmlNode node in rssNodes)
            {
                String picUrl = node["media:content"]?.Attributes["url"]?.Value;
                stories.Add(new Story()
                {
                    Title = node["title"]?.InnerText,
                    Content = node["description"]?.InnerText,
                    Picture = toImgSource(picUrl)
            });
            }

            return stories;
        }
    }
}
