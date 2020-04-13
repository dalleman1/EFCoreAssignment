using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Student
    {
        [Key]
        public string AuId { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }

        //Exercise
        [ForeignKey(nameof(Exercise.lecture))]
        List<Exercise> exercises { get; set; }

        //InCourse
        [ForeignKey(nameof(StudentsInCourse.auId))]
        List<StudentsInCourse> studentsInCourses { get; set; }

        //Review
        [ForeignKey(nameof(Review.auId))]
        Review review { get; set; }

        //Help Request
        [ForeignKey(nameof(HelpRequest.auId))]
        List<HelpRequest> helpRequests { get; set; }

        [ForeignKey(nameof(HelpRequestExercise.auId))]
        List<HelpRequestExercise> helpRequestExercises { get; set; }
    }
}
