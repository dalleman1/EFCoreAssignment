using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class HelpRequestConfiguration : IEntityTypeConfiguration<HelpRequest>
    {
        public void Configure(EntityTypeBuilder<HelpRequest> entity)
        {
            entity.HasData(
                new HelpRequest { auId = "Au616638", assignmentId = 1 },
                new HelpRequest { auId = "Au616638", assignmentId = 2 },
                new HelpRequest { auId = "Au612638", assignmentId = 4 }
                );
        }
    }
}
