namespace WUG.Core.Services.DataEntities
{
    public class BranchInfo
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public CountryInfo Country { get; set; }
    }
}
