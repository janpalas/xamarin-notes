using System.Collections.Generic;
using System.Threading.Tasks;
using WUG.Core.Services.DataEntities;

namespace WUG.Client.Shared.Models
{
    public interface IEventProvider
    {
        Task<List<EventInfo>> GetUpcomingEventsAsync();
    }
}
