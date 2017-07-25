using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class PhotoInfo
    {
        public int PhotoID { get; set; }
        public string DownloadThumbnailUrlPattern {get; set;}
        public List<ThumbnailDetail> Thumbnails { get; set; }
    }
}
