using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Assignment
    {
        public int assignmentId { get; set; }

        //Review
        public int reviewId { get; set; }
        List<Review> reviews { get; set; }

        //Student
        public int studentId { get; set; }
        List<Student> students { get; set; }

        //Course
        public int courseId { get; set; }
        Course course { get; set; }

        //Teacher
        public int teacherId { get; set; }
        Teacher teacher { get; set; }

        //Helprequest
        public int helprequestId { get; set; }
        List<HelpRequest> helpRequests { get; set; }
    }
}
