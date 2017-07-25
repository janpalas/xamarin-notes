namespace WUG.Core.Services.DataEntities
{
    public class MultimediaStreamDetail
    {
        public int MultimediaStreamID { get; set; }
        public int MultimediaContentItemID { get; set; }
        public string StreamUrl { get; set; }
        public string StreamFormat { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int? FileSize { get; set; }
    }
}
