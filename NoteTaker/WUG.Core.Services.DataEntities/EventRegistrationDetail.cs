using System;

namespace WUG.Core.Services.DataEntities
{
    public class EventRegistrationDetail
    {
        public Guid RegistrationGUID { get; set; }
        public UserInfo User { get; set; }
        public EventInfo Event { get; set; }
        public DateTime Registered { get; set; }
        public int? RegistrationPosition { get; set; }
        public int? RegisteredUsersLimit { get; set; }
        public RegistrationState RegistrationState { get; set; }
        public DateTime? RegistrationConfirmed { get; set; }
        public DateTime? RegistrationRejected { get; set; }
        public bool? IsConfirmedPresence { get; set; }
    }

    public enum RegistrationState
    {
        unconfirmed,
        confirmed,
        rejected
    }
}
