using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.HasData(
                new Student { AuId = "Au616638", Name = "Bjarke Bjarkesen", Semester = 4, },
                new Student { AuId = "Au612638", Name = "Morten Bjarkesen", Semester = 3, },
                new Student { AuId = "Au632638", Name = "Bjarke Mortensen", Semester = 2, },
                new Student { AuId = "Au652638", Name = "Morten Mortensen", Semester = 4, },
                new Student { AuId = "Au616621", Name = "Oliver Madsen", Semester = 4, },
                new Student { AuId = "Au631321", Name = "Mads Oliversen", Semester = 5, },
                new Student { AuId = "Au614328", Name = "Mads Madsen", Semester = 1, },
                new Student { AuId = "Au612238", Name = "Oliver Oliversen", Semester = 4, }
                );
        }
    }
}
