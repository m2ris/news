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
                Date = "2016.05.21"
            });
            stories.Add(new Story() {
                Title = "teine",
                Content = "Check it out hizzle that's the shizzle. We gonna chung erizzle.",
                Date = "2016.03.12"

            });
            return stories;
        }
    }
}
