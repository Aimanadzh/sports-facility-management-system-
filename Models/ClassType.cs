namespace FacilityApp.Models
{
    public class ClassType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Navigation
        public ICollection<InstructorSkill>? InstructorSkills { get; set; }
        public ICollection<Session>? Sessions { get; set; }
    }
}
