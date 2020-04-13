using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class TeacherHelpsWithExerciseConfiguration : IEntityTypeConfiguration<TeacherHelpsWithExercise>
    {
        public void Configure(EntityTypeBuilder<TeacherHelpsWithExercise> entity)
        {
            entity.HasData(
                new TeacherHelpsWithExercise { auId = "Au420322", number = 1},
                new TeacherHelpsWithExercise { auId = "Au616639", number = 2 },
                new TeacherHelpsWithExercise { auId = "Au420322", number = 2 },
                new TeacherHelpsWithExercise { auId = "Au620433", number = 6 }
                );
        }
    }
}
