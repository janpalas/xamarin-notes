using System;
using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class MultimediaContentItemDetail
    {
        public int MultimediaContentItemID { get; set; }
        public string Name { get; set; }
        public List<MultimediaStreamDetail> MultimediaStreams { get; set; }
        public EventDetail Event { get; set; }
        public List<SpeakerDetail> Speakers { get; set; }
        public string Description { get; set; }
        public string AuthorDisplayName { get; set; }
        public int Length { get; set; }
        public DateTime Published { get; set; }
        public int PlayedTotalTimes { get; set; }
        public List<PhotoInfo> Photos { get; set; }
    }
}
