using System;
using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class EventDetail
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public DateTime TakePlaceFrom { get; set; }
        public DateTime TakePlaceTo { get; set; }
        public EventType EventType { get; set; }
        public BranchInfo Branch { get; set; }
        public EventPlaceDetail EventPlace { get; set; }
        public List<SpeakerDetail> Speakers { get; set; }
        public DateTime Published { get; set; }
        public EventStatus EventStatus { get; set; }
        public string Annotation { get; set; }
        public string AnnotationDetail { get; set; }
        public string Schedule { get; set; }
        public string Summary { get; set; }
        public string RecommendedKnowledge { get; set; }
        public string CancelReason { get; set; }
        public int? RegisteredUsersLimit { get; set; }
        public List<EventRegistrationStatisticInfo> RegisteredUserStatistics { get; set; }
        public List<PhotoInfo> Photos { get; set; }
        public List<MultimediaContentItemInfo> MultimediaContentItems { get; set; }
    }
}
