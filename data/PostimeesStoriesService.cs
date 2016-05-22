using News.Helpers;
using News.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml;

namespace News.data
{
    class PostimeesStoriesService : StoriesService
    {
        public ObservableCollection<Story> loadStories()
        {
            ObservableCollection<Story> stories = new ObservableCollection<Story>();

            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.postimees.ee/rss/");

            XmlNodeList news = doc.SelectNodes("rss/channel/item");

            foreach(XmlNode item in news)
            {
                string imageUrl = item["media:content"].Attributes["url"].Value;

                stories.Add(new Story()
                {
                    Title = item["title"].InnerText,
                    Author = item["dc:creator"].InnerText,
                    Content = item["description"].InnerText,
                    Date = item["pubDate"].InnerText,
                    Picture = ImageUrlConverter.ToImageSource(imageUrl)
                });
            }

            return stories;
        }

      
    }
}