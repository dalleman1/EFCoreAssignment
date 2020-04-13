using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Review
    {
        public string auId { get; set; }
        public string Reviewtext { get; set; }

        //Assignment
        public int assignmentId { get; set; }
        Assignment assignment { get; set; }

        //Student
        Student student { get; set; }

    }
}
