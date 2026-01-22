using FacilityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FacilityApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionSignup> SessionSignups { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<InstructorSkill> InstructorSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite unique key for InstructorSkills
            modelBuilder.Entity<InstructorSkill>()
                .HasIndex(i => new { i.InstructorUserId, i.ClassTypeId })
                .IsUnique();

            // Composite unique key for SessionSignups
            modelBuilder.Entity<SessionSignup>()
                .HasIndex(s => new { s.SessionId, s.MemberUserId })
                .IsUnique();
        }
    }
}
