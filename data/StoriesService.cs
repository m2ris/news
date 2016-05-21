using News.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.data
{
    class StoriesService
    {
        public ObservableCollection<Story> loadStories()
        {
            ObservableCollection<Story> stories = new ObservableCollection<Story>();
            stories.Add(new Story() {
                Title = "esimene",
                Content = "Lorizzle ipsum bling bling sit amizzle, consectetuer adipiscing elit.",
                Date = new DateTime(2016, 05, 21),
                Picture = "http://www.microsoft.com/silverlight/images/ms-silverlight-logo.png"
            });
            stories.Add(new Story() {
                Title = "teine",
                Content = "Check it out hizzle that's the shizzle. We gonna chung erizzle.",
                Date = new DateTime(2016, 05, 21),
                Picture = "http://www.microsoft.com/silverlight/images/ms-silverlight-logo.png"
            });
            return stories;
        }
    }
}
