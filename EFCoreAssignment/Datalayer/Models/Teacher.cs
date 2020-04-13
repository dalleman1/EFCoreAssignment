using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Teacher
    {
        [Key]
        public string AuId { get; set;}
        public string Name { get; set; }

        // Exercise
        [ForeignKey(nameof(TeacherHelpsWithExercise.Number))]
        List<TeacherHelpsWithExercise> teacherHelpsWithExercises { get; set; }


        // Assignment
        [ForeignKey(nameof(TeacherHelpsWith.auId))]
        List<TeacherHelpsWith> teacherHelpsWiths { get; set; }

        // Course
        public int courseId { get; set; }
        Course course { get; set; }
    }
}
