using News.data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.model
{
    class MainWindowVM : BaseVM, INotifyPropertyChanged
    {
        #region SelectedStory
        private Story _selectedStory;

        public Story SelectedStory
        {
            get
            {
                return _selectedStory;
            }
            set
            {
                _selectedStory = value;
                OnPropertyChanged("SelectedStory");
            }
        }
        #endregion

        #region Stories
        private ObservableCollection<Story> _stories = new ObservableCollection<Story>();

        public ObservableCollection<Story> Stories
        {
            get
            {
                return _stories;
            }
            set
            {
                _stories = value;
                OnPropertyChanged("Stories");
            }
        }
        #endregion

        #region StoriesService
        private StoriesService _storiesService;

        public StoriesService StoriesService
        {
            get
            {
                return _storiesService;
            }
            set
            {
                _storiesService = value;
                Stories = new ObservableCollection<Story>(StoriesService.loadStories());
                OnPropertyChanged("StoriesService");
            }
        }
        #endregion

        public MainWindowVM()
        {
            StoriesService = new PostimeesStoriesService();
        }
    }
}
