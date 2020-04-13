using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class TeacherHelpsWithExercise
    {
        public string auId { get; set; }
        Teacher teacher { get; set; }
        public int Number { get; set; }
        Exercise exercise { get; set; }
    }
}
