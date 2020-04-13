using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using EFCoreAssignment.Datalayer.QueryRepository;
using System;

namespace EFCoreAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlinehelpViews View = new OnlinehelpViews();
            OnlinehelpContext onlinehelpContext = new OnlinehelpContext();

            //// Given (teacher, course) print list of all open help request with information where the studentscan be contacted
            View.GetHelpRequestExercises("Au616639", 1);

            Console.WriteLine("");

            //// Given (student) print list of all students open help requests
            View.AllOpenHelpRequest("Au616638");

            Console.WriteLine("");  

            //// Print statistic of all help request per course, so how many requests have been made, how many are open etc
            View.PrintAllCourseStatistics();

            Console.WriteLine("");


            TeacherRepository teacher = new TeacherRepository(onlinehelpContext);
            AssignmentRepository assignment = new AssignmentRepository(onlinehelpContext);
            CourseRepository course = new CourseRepository(onlinehelpContext);
            ExerciseRepository exercise = new ExerciseRepository(onlinehelpContext);
            HelpRequestRepository helpRequest = new HelpRequestRepository(onlinehelpContext);
            ReviewRepository review = new ReviewRepository(onlinehelpContext);
            StudentRepository student = new StudentRepository(onlinehelpContext);


            /* @Note:
             * Below are the data you need to use when creating a new
             * tuple entry in the database.
             * 
             * Assignment a = new Assignment { courseId =  };
             * Teacher t = new Teacher { AuId = , courseId = , Name = };
             * Course c = new Course { Name = };
             * Exercise e = new Exercise { courseId = , lecture =5, number = };
             * Student s = new Student { AuId = , Name = , Semester = };
             * Review r = new Review { auId = , assignmentId = 1, Reviewtext =  };
             * HelpRequest hr = new HelpRequest { assignmentId = , auId =  };
             * 
             * @Example:
             * 
             * I want to add a new teacher to the database:
             * 
             * 1. Create the Teacher
             * 
             * Teacher newTeacher = new Teacher { AuId = "au1337", courseId = 3, Name = "Ole Olesen" }
             * 
             * 2. Use the TeacherRepository instance to call the AddAsync function
             * 
             * teacher.AddAsync(newTeacher).Wait(); // Wait makes sure that the database is updated.
             * 
             * 3. Profit.
             * 
             * If you want to see the newly added tuple, go to the database in Server Explorer.
             * 
            */

            while(true)
            {

            }

        }
    }
}
