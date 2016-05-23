using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.model;
using System.Xml;

namespace News.data
{
    public class DelfiStoriesService : StoriesService
    {
        public List<Story> loadStories()
        {
            List<Story> stories = new List<Story>();

            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.delfi.ee/rss");

            XmlNodeList news = doc.SelectNodes("rss/channel/item");

            foreach (XmlNode item in news)
            {
                stories.Add(new Story()
                {
                    Title = item["title"].InnerText,
                    Description = item["description"].InnerText,
                    Date = item["pubDate"].InnerText,
                });
            }

            return stories;
        }
    }
}

