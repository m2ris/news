using News.Helpers;
using News.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.data
{
    public class MockedStoriesService : StoriesService
    {
        public List<Story> loadStories()
        {
            List<Story> stories = new List<Story>();
            stories.Add(new Story() {
                Title = "esimene",
                Author = "nipitiri",
                Description = "Lorizzle ipsum bling bling sit amizzle, consectetuer adipiscing elit.",
                Date = "2016.05.21",
                Picture = ImageUrlConverter.ToImageSource("http://i.kinja-img.com/gawker-media/image/upload/s--ft1APKVa--/18a5kzrhxhqwvjpg.jpg")
            });
            stories.Add(new Story() {
                Title = "teine",
                Author = "kollane elevant",
                Description = "Check it out hizzle that's the shizzle. We gonna chung erizzle.",
                Date = "2016.03.12",
                //Picture= "ikka pilt"
            });
            stories.Add(new Story()
            {
                Title = "kolmas",
                Author = "pipi",
                Description = "Fo izzle dolor fo turpis tempizzle tempor.",
                Date = "2011.07.12",
                Picture = ImageUrlConverter.ToImageSource("https://i.ytimg.com/vi/1v6M41Divso/maxresdefault.jpg")
            });
            return stories;
        }
    }
}
