using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.HasData(
                new Course { courseId = 1, Name = "DAB"},
                new Course { courseId = 2, Name = "GFV" },
                new Course { courseId = 3, Name = "ISU" }
                );
        }
    }
}
