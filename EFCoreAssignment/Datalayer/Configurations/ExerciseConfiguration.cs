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
                new Exercise { exerciseId = 1, lecture = 1, number = 1, studentId = 1 },
                new Exercise { exerciseId = 2, lecture = 1, number = 1, studentId = 1 },
                new Exercise { exerciseId = 3, lecture = 1, number = 1, studentId = 1 },
                new Exercise { exerciseId = 4, lecture = 1, number = 1, studentId = 5 }
                );
        }
    }
}