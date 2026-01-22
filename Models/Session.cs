using System.ComponentModel.DataAnnotations.Schema;
namespace FacilityApp.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int ClassTypeId { get; set; }
        public int InstructorUserId { get; set; }   // real column in DB
        public int RoomId { get; set; } //get the room id 
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Capacity { get; set; } = 3;
        public bool IsLocked { get; set; }
        public bool IsCancelled { get; set; }

        // Navigation
        public ClassType? ClassType { get; set; }

        // 👇 Add this [ForeignKey] attribute so EF maps it correctly
        [ForeignKey("InstructorUserId")]
        public User? Instructor { get; set; }

        public Room? Room { get; set; }
        public ICollection<SessionSignup>? Signups { get; set; }
    }
}
