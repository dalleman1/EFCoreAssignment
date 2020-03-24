using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Teacher
    {
        public int teacherId { get; set; }
        public string AuId { get; set;}
        public string Name { get; set; }

        // Exercise
        public int exerciseId { get; set; }
        List<Exercise> exercises { get; set; }

        // Assignment
        public int assignmentId { get; set; }
        List<Assignment> assignments { get; set; }

        // Course
        public int courseId { get; set; }
        Course course { get; set; }
    }
}
