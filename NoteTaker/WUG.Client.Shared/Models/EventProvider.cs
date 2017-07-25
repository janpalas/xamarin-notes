using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WUG.Client.Shared.PlatformAbstractions;
using WUG.Core.Services.DataEntities;

namespace WUG.Client.Shared.Models
{
    public class EventProvider : IEventProvider
    {
        private readonly IWebClient _webClient;

        private const string ServiceUrl = @"https://api.wug.cz/events/upcoming?ApplicationKey=45CE4F59-1B28-4F6A-B31B-5ED8BA5CE679";

        public EventProvider(IWebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<List<EventInfo>> GetUpcomingEventsAsync()
        {
            string json = await _webClient.GetStringAsync(new Uri(ServiceUrl));
            return JsonConvert.DeserializeObject<List<EventInfo>>(json);
        }
    }
}
