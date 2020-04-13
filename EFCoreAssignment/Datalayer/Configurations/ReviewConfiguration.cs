using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> entity)
        {
            entity.HasData(
                new Review { auId = "Au616621", assignmentId = 1, Reviewtext = "Fint nok" },
                new Review { auId = "Au616621", assignmentId = 2, Reviewtext = "Helt ok" },
                new Review { auId = "Au616621", assignmentId = 3, Reviewtext = "Meget fint" }
                );
        }
    }
}
