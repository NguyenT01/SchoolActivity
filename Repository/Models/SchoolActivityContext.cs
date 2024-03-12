using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class SchoolActivityContext : DbContext
{
    public SchoolActivityContext()
    {
    }

    public SchoolActivityContext(DbContextOptions<SchoolActivityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-STBRGUF\\SQLEXPRESS;Database=SchoolActivity;Persist Security Info=False;Trusted_Connection=True;TrustServerCertificate=True;");

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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
