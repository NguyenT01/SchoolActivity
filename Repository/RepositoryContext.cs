using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Repository.Entities;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>(entity =>
            {
                entity.HasKey(e => new { e.ClassroomId, e.Month, e.Week }).HasName("PK__Classroo__F24A31D8BC55C73F");

                entity.ToTable("Classroom");

                entity.Property(e => e.ClassroomId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.ApplyConfiguration<Classroom>(new ClassroomConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<Classroom> Classrooms { get; set; }
    }
}
