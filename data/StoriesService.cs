using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using News.model;

namespace News.data
{
    interface StoriesService
    {
        ObservableCollection<Story> loadStories();   
    }
}
