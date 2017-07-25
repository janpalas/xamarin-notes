using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using WUG.Client.Shared.Models;
using WUG.Client.Shared.ViewModels.Entity;
using WUG.Core.Services.DataEntities;

namespace WUG.Client.Shared.ViewModels.Page
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IEventProvider _eventProvider;

        private ObservableCollection<EventInfoViewModel> _upcomingEvents;

        public ObservableCollection<EventInfoViewModel> UpcomingEvents
        {
            get => _upcomingEvents;
            set
            {
                if (_upcomingEvents != value)
                {
                    _upcomingEvents = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public MainPageViewModel(IEventProvider eventProvider)
        {
            _eventProvider = eventProvider;
        }

        public async Task LoadDataAsync()
        {
            List<EventInfo> events = await _eventProvider.GetUpcomingEventsAsync();

            UpcomingEvents = new ObservableCollection<EventInfoViewModel>(events.Select(x => new EventInfoViewModel(x)));
        }
    }
}
