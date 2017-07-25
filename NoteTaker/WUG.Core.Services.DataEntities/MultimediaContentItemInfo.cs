using System;
using System.Collections.Generic;

namespace WUG.Core.Services.DataEntities
{
    public class MultimediaContentItemInfo
    {
        public int MultimediaContentItemID { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public DateTime Published { get; set; }
        public List<PhotoInfo> Photos { get; set; }
    }
}
