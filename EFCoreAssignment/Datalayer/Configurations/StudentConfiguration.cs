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
                new Student { StudentId = 1, AuId = "au616639", Name = "Morten Dalsgaard", },
                new Student { StudentId = 2, AuId = "au382010", Name = "", },
                new Student { StudentId = 3, AuId = "au616333", Name = "", },
                new Student { StudentId = 4, AuId = "au615063", Name = "", },
                new Student { StudentId = 5, AuId = "au616604", Name = "", },
                new Student { StudentId = 6, AuId = "au453232", Name = "", },
                new Student { StudentId = 7, AuId = "au549032", Name = "", },
                new Student { StudentId = 8, AuId = "au450321", Name = "", }
                );
        }
    }
}
