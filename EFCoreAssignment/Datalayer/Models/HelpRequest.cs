using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class HelpRequest
    {
        public int helprequestId { get; set; }

        //Student
        public int studentId { get; set; }
        Student student { get; set; }

        //Assignment
        public int assignmentId { get; set; }
        Assignment assignment { get; set; }

        //Exercise
        public int exerciseId { get; set; }
        Exercise exercise { get; set; }
    }
}
