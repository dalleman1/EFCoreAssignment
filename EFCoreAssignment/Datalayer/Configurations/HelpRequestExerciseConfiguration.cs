using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class HelpRequestExerciseConfiguration : IEntityTypeConfiguration<HelpRequestExercise>
    {
        public void Configure(EntityTypeBuilder<HelpRequestExercise> entity)
        {
            entity.HasData(
                new HelpRequestExercise { auId = "Au614328", helpwhere = "Bord 20", number = 2 },
                new HelpRequestExercise { auId = "Au612238", helpwhere = "Bord 22", number = 1 },
                new HelpRequestExercise { auId = "Au614328", helpwhere = "Bord 21", number = 1 },
                new HelpRequestExercise { auId = "Au616638", helpwhere = "Bord 23", number = 6 }
                );
        }
    }
}
