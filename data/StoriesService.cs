using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.model;

namespace News.data
{
    public interface StoriesService
    {
        List<Story> loadStories();   
    }
}
