﻿using News.model;
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
                Author = "nipitiri",
                Content = "Lorizzle ipsum bling bling sit amizzle, consectetuer adipiscing elit.",
                Date = "2016.05.21",
                Picture = "http://i.kinja-img.com/gawker-media/image/upload/s--ft1APKVa--/18a5kzrhxhqwvjpg.jpg"
            });
            stories.Add(new Story() {
                Title = "teine",
                Author = "kollane elevant",
                Content = "Check it out hizzle that's the shizzle. We gonna chung erizzle.",
                Date = "2016.03.12",
                Picture= "ikka pilt"
            });
            stories.Add(new Story()
            {
                Title = "kolmas",
                Author = "pipi",
                Content = "Fo izzle dolor fo turpis tempizzle tempor.",
                Date = "2011.07.12",
                Picture = "https://i.ytimg.com/vi/1v6M41Divso/maxresdefault.jpg"
            });
            return stories;
        }
    }
}
