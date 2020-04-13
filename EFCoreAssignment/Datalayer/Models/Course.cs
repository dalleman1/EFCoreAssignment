using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Course
    {
        [Key]
        public int courseId { get; set; }
        public string Name { get; set; }

        //Teacher
        [ForeignKey(nameof(Teacher.AuId))]       
        List<Teacher> teachers { get; set; }

        //InCourse
        [ForeignKey(nameof(StudentsInCourse.courseId))]
        List<StudentsInCourse> studentsInCourses { get; set; }

        //Assignment
        [ForeignKey(nameof(Assignment.assignmentId))]
        List<Assignment> assignments { get; set; }

        [ForeignKey(nameof(Exercise.courseId))]
        List<Exercise> exercises { get; set; }
    }
}
