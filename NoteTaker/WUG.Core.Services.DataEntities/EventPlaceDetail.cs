using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class EventPlaceDetail
    {
        public int EventPlaceID { get; set; }
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string AddressStreetNumber { get; set; }
        public CountryInfo AddressCountry { get; set; }
        public string Description { get; set; }
        public string TravelDescription { get; set; }
        public double? LocationLatitude { get; set; }
        public double? LocationLongitude { get; set; }
        public string WebSiteUrl { get; set; }
        public List<PhotoInfo> Photos { get; set; }
    }
}
