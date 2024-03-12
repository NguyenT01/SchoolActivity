using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entities;

namespace Repository.Configuration
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasData(
                    new Classroom
                    {
                        ClassroomId = "6A1",
                        ActivityPoints = 90,
                        MinusPoints = 4,
                        Month = 1,
                        Week = 1
                    },
                    new Classroom
                    {
                        ClassroomId = "6A1",
                        ActivityPoints = 85,
                        MinusPoints = 10,
                        Month = 1,
                        Week = 2
                    },
                    new Classroom
                    {
                        ClassroomId = "6A1",
                        ActivityPoints = 100,
                        MinusPoints = 5,
                        Month = 1,
                        Week = 3
                    },
                    new Classroom
                    {
                        ClassroomId = "7A2",
                        ActivityPoints = 60,
                        MinusPoints = 16,
                        Month = 1,
                        Week = 1
                    },
                    new Classroom
                    {
                        ClassroomId = "7A2",
                        ActivityPoints = 100,
                        MinusPoints = 12,
                        Month = 1,
                        Week = 2
                    },
                    new Classroom
                    {
                        ClassroomId = "7A2",
                        ActivityPoints = 85,
                        MinusPoints = 0,
                        Month = 1,
                        Week = 3
                    }
                );
        }
    }
}
