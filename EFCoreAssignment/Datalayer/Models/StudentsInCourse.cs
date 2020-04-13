using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class StudentsInCourse
    {
        public string auId { get; set; }
        Student student { get; set;  }
        public int courseId { get; set; }
        Course course { get; set; }
    }
}
