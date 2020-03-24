using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Exercise
    {
        public int exerciseId { get; set; }
        public int lecture { get; set; } 
        public int number { get; set; }
        public int helpwhere { get; set; }
        //Student
        public int studentId { get; set; }
        Student student { get; set; }

        //Teacher
        public int teacherId { get; set; }
        Teacher teacher { get; set; }

        //Helprequest
        public int helprequestId { get; set; }
        List<HelpRequest> helpRequests { get; set; }
    }
}
