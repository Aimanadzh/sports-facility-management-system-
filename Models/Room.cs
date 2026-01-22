namespace FacilityApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public decimal HourlyRate { get; set; }
        public string? PhotoUrl { get; set; }
        public bool IsLocked { get; set; }

        // Navigation
        public ICollection<Session>? Sessions { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
