namespace WUG.Core.Services.DataEntities
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public CountryInfo Country { get; set; }
    }
}
