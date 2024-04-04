using Microsoft.EntityFrameworkCore;

namespace DoctoCare.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Physician> Physician { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>().HasKey(p => p.Id);
            modelBuilder.Entity<Physician>().HasKey(m => m.Id);
            modelBuilder.Entity<RendezVous>().HasKey(r => r.RendezVousId);

            modelBuilder.Entity<RendezVous>()
                .HasOne(r => r.Patient)
                .WithMany(p => p.RendezVous)
                .HasForeignKey(r => r.PatientId);

            modelBuilder.Entity<RendezVous>()
                .HasOne(r => r.Physician)
                .WithMany(m => m.RendezVous)
                .HasForeignKey(r => r.PhysicianId);
        }
    }
}
