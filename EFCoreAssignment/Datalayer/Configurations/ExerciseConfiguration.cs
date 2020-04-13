using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> entity)
        {
            entity.HasData(
                new Exercise { lecture = 1, number = 1, courseId = 1},
                new Exercise { lecture = 1, number = 2, courseId = 1},
                new Exercise { lecture = 4, number = 1, courseId = 2},
                new Exercise { lecture = 10, number = 6, courseId = 3}
                );
        }
    }
}