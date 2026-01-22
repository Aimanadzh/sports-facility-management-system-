namespace FacilityApp.Models
{
    public class SessionSignup
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int MemberUserId { get; set; }
        public DateTime SignedUpAt { get; set; }

        // Navigation
        public Session? Session { get; set; }
        public User? Member { get; set; }
    }
}
