using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class StudentInCourseConfiguration : IEntityTypeConfiguration<StudentsInCourse>
    {
        public void Configure(EntityTypeBuilder<StudentsInCourse> entity)
        {
            entity.HasData(
                new StudentsInCourse { auId = "Au616638", courseId = 1},
                new StudentsInCourse { auId = "Au616621", courseId = 1 },
                new StudentsInCourse { auId = "Au616621", courseId = 3 },
                new StudentsInCourse { auId = "Au616638", courseId = 3 },
                new StudentsInCourse { auId = "Au616638", courseId = 2 },
                new StudentsInCourse { auId = "Au616621", courseId = 2 },
                new StudentsInCourse { auId = "Au631321", courseId = 3 },
                new StudentsInCourse { auId = "Au612638", courseId = 2 },
                new StudentsInCourse { auId = "Au612638", courseId = 3 },
                new StudentsInCourse { auId = "Au612638", courseId = 1 }
                );
        }
    }
}
