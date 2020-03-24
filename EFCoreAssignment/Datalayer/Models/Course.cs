using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string Name { get; set; }

        //Teacher
        public int teacherId { get; set; }
        List<Teacher> teachers { get; set; }

        //Student
        public int studentId { get; set; }
        List<Student> students { get; set; }

        //Assignment
        public int assignmentId { get; set; }
        List<Assignment> assignments { get; set; }
    }
}
