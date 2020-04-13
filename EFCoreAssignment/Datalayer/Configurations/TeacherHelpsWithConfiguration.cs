using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class TeacherHelpsWithConfiguration : IEntityTypeConfiguration<TeacherHelpsWith>
    {
        public void Configure(EntityTypeBuilder<TeacherHelpsWith> entity)
        {
            entity.HasData(
                new TeacherHelpsWith { auId = "Au620433", assignmentId = 1},
                new TeacherHelpsWith { auId = "Au504234", assignmentId = 2 },
                new TeacherHelpsWith { auId = "Au420322", assignmentId = 3 },
                new TeacherHelpsWith { auId = "Au302420", assignmentId = 4 }
                );
        }
    }
}
