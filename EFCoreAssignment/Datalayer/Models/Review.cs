using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Review
    {
        public int reviewId { get; set; }
        public string Reviewtext { get; set; }

        //Assignment
        public int assignmentId { get; set; }
        Assignment assignment { get; set; }

        //Student
        public int studentId { get; set; }
        Student student { get; set; }

    }
}
