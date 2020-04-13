using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> entity)
        {
            entity.HasData(
                new Teacher { AuId = "Au616639", Name = "Morten Bobsen", courseId = 1},
                new Teacher { AuId = "Au620433", Name = "Kaj Løkke", courseId = 1},
                new Teacher { AuId = "Au504234", Name = "Kasper Kaj", courseId = 2},
                new Teacher { AuId = "Au420322", Name = "Mads Madsen", courseId = 2},
                new Teacher { AuId = "Au302420", Name = "Oliver Escobar", courseId = 3}
                );
        }
    }
}
