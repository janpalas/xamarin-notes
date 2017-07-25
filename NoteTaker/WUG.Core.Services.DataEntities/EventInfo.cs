using System;
using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class EventInfo
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public DateTime TakePlaceFrom { get; set; }
        public DateTime TakePlaceTo { get; set; }
        public EventType EventType { get; set; }
        public BranchInfo Branch { get; set; }
        public EventPlaceInfo EventPlace { get; set; }
        public List<SpeakerInfo> Speakers { get; set; }
        public DateTime Published { get; set; }
        public EventStatus EventStatus { get; set; }
    }
    public enum EventType
    {
        meeting,
        handsonlab
    }
    public enum EventStatus
    {
        published,
        canceled
    }
}
