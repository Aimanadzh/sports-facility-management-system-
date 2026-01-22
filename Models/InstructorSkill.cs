namespace FacilityApp.Models
{
    public class InstructorSkill
    {
        public int Id { get; set; }
        public int InstructorUserId { get; set; }
        public int ClassTypeId { get; set; }

        // Navigation
        public User? Instructor { get; set; }
        public ClassType? ClassType { get; set; }
    }
}
