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
                new TeacherHelpsWithExercise { auId = "Au420322", Number = 1},
                new TeacherHelpsWithExercise { auId = "Au616639", Number = 2 },
                new TeacherHelpsWithExercise { auId = "Au420322", Number = 1 },
                new TeacherHelpsWithExercise { auId = "Au620433", Number = 6 }
                );
        }
    }
}
