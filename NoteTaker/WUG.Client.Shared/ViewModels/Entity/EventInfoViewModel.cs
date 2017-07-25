using WUG.Core.Services.DataEntities;

namespace WUG.Client.Shared.ViewModels.Entity
{
    public class EventInfoViewModel
    {
        private readonly EventInfo _eventInfo;

        public EventInfoViewModel(EventInfo eventInfo)
        {
            _eventInfo = eventInfo;
        }

        public string Name => _eventInfo.Name;
        public string BranchName => _eventInfo.Branch.Name;
        public int TakePlaceFromDay => _eventInfo.TakePlaceFrom.Day;

    }
}
