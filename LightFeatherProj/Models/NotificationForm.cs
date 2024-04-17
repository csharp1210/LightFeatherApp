namespace LightFeatherProj.Models
{
    public class NotificationForm
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Supervisor Supervisor { get; set; }
    }
}
