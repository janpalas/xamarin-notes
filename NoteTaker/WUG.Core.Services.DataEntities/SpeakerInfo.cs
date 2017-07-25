using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class SpeakerInfo
    {
        public int SpeakerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Suffix { get; set; }
        public string DisplayedTitles { get; set; }
        public List<PhotoInfo> Photos { get; set; }
    }
}
