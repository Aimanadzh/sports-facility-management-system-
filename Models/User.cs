namespace FacilityApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public string Role { get; set; } = "member"; // default role
        // Navigation
        //public ICollection<InstructorSkill>? InstructorSkills { get; set; }
        //public ICollection<Session>? Sessions { get; set; }
        //public ICollection<Booking>? Bookings { get; set; }
    }
}
