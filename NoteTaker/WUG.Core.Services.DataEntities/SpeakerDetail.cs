using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class SpeakerDetail
    {
        public int SpeakerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string CompanyWebSiteUrl { get; set; }
        public string Title { get; set; }
        public string Suffix { get; set; }
        public string DisplayedTitles { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string PersonalWebSiteUrl { get; set; }
        public string PersonalBlogUrl { get; set; }
        public string OtherWebSiteUrl { get; set; }
        public string OtherWebSiteName { get; set; }
        public string LinkedInProfileUrl { get; set; }
        public string TwitterAccountName { get; set; }
        public string CV { get; set; }
        public string Certifications { get; set; }
        public string Hobbies { get; set; }
        public string Specialization { get; set; }
        public List<PhotoInfo> Photos { get; set; }
    }
}
