using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class BranchDetail
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public CountryInfo Country { get; set; }
        public string HomePageUrl { get; set; }
        public string ContactEmail { get; set; }
        public string BasicInfo { get; set; }
        public string History { get; set; }
        public List<SpeakerInfo> Organizers { get; set; }
    }
}
