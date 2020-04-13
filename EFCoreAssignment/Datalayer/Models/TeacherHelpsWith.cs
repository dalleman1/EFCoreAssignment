using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class TeacherHelpsWith
    {
        public string auId { get; set; }
        Teacher teacher { get; set; }
        public int assignmentId { get; set; }
        Assignment assignment { get; set; }
    }
}
