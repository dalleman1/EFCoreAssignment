﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAssignment.Datalayer.Models
{
    public class Exercise
    {
        //Composite key set in modelcreating
        public int lecture { get; set; }
        public int number { get; set; }


        [ForeignKey(nameof(TeacherHelpsWithExercise.auId))]
        TeacherHelpsWithExercise teacherHelpsWithExercise { get; set; }

        //HelprequestExercise
        [ForeignKey(nameof(HelpRequestExercise.number))]
        HelpRequestExercise helpRequestExercises { get; set; }

        public int courseId { get; set; }
        Course course { get; set; }
    }
}
