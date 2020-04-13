using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class HelpRequestExercise
    {
        public string auId { get; set; }
        public string helpwhere { get; set; }
        Student student { get; set; }

        public int number { get; set; }
        Exercise exercise { get; set;  }
    }
}
