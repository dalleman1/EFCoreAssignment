using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> entity)
        {
            entity.HasData(
                new Assignment {  assignmentId = 1, courseId = 1},
                new Assignment { assignmentId = 2, courseId = 1 },
                new Assignment { assignmentId = 3, courseId = 2 },
                new Assignment { assignmentId = 4, courseId = 3 }
                );
        }
    }
}
