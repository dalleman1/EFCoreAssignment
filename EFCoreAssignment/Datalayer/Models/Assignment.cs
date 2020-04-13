using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Assignment
    {
        [Key]
        public int assignmentId { get; set; }

        //Review
        [ForeignKey(nameof(Review.assignmentId))]
        List<Review> reviews { get; set; }


        //Course
        public int courseId { get; set; }
        Course course { get; set; }

        //Teacher
        [ForeignKey(nameof(TeacherHelpsWith.assignmentId))]
        TeacherHelpsWith teacherHelpsWith { get; set; }

        //Helprequest
        [ForeignKey(nameof(HelpRequest.assignmentId))]
        List<HelpRequest> helpRequests { get; set; }
    }
}
