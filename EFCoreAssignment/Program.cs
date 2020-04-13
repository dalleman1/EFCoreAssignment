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
            //View.GetHelpRequestExercises("Au616639", 1);

            //Console.WriteLine("");

            //// Given (student) print list of all students open help requests
            //View.AllOpenHelpRequest("Au616638");

            //Console.WriteLine("");  

            //// Print statistic of all help request per course, so how many requests have been made, how many are open etc
            //View.PrintAllCourseStatistics();

            //Console.WriteLine("");


            TeacherRepository teacher = new TeacherRepository(onlinehelpContext);
            AssignmentRepository assignment = new AssignmentRepository(onlinehelpContext);
            CourseRepository course = new CourseRepository(onlinehelpContext);
            ExerciseRepository exercise = new ExerciseRepository(onlinehelpContext);
            HelpRequestRepository helpRequest = new HelpRequestRepository(onlinehelpContext);
            ReviewRepository review = new ReviewRepository(onlinehelpContext);
            StudentRepository student = new StudentRepository(onlinehelpContext);


            Assignment a = new Assignment { assignmentId = 5, courseId = 1 };
            Teacher t = new Teacher { AuId = "Au123213", courseId = 1, Name = "Bjørn BJARNE" };
            Course c = new Course { Name = "SWT", courseId = 4 };
            Exercise e = new Exercise { courseId = 2, lecture = 1, number = 1 };
            Student s = new Student { AuId = "Au629321", Name = "Ronja Røverdatter", Semester = 1 };
            Review r = new Review { auId = "Au631321", assignmentId = 1, Reviewtext = "Dette er mega godt lavet" };
            HelpRequest hr = new HelpRequest { assignmentId = 1, auId = "Au612238" };


            // Adds a new creation
            teacher.AddAsync(t).Wait();
            assignment.AddAsync(a).Wait();
            course.AddAsync(c).Wait();
            exercise.AddAsync(e).Wait();
            helpRequest.AddAsync(hr).Wait();
            review.AddAsync(r).Wait();
            student.AddAsync(s).Wait();

            // Prints again to see a change - Else check the table contents in the server explorer
            //View.PrintAllCourseStatistics();

            Console.ReadLine();
        }
    }
}
