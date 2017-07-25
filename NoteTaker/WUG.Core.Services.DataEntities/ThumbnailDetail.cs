using System.Runtime.Serialization;

namespace WUG.Core.Services.DataEntities
{
    [DataContract(Name="TD")]
    public class ThumbnailDetail
    {
        [DataMember(Name="TID")]
        public int ThumbnailID { get; set; }
        [DataMember(Name = "TSN")]
        public string ThumbnailSizeName { get; set; }
        [DataMember(Name = "W")]
        public int Width { get; set; }
        [DataMember(Name = "H")]
        public int Height { get; set; }
        [DataMember(Name = "FS")]
        public int FileSize { get; set; }
        [DataMember(Name = "FT")]
        public string FileType { get; set; }
    }
}
