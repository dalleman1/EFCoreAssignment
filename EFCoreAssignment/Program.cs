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
            
            //View.GetHelpRequestExercises("Au616639", 1);

            //View.AllOpenHelpRequest("Au616638");

            //View.PrintAllCourseStatistics();

            TeacherRepository teacher = new TeacherRepository(onlinehelpContext);

            teacher.AddAsync(new Teacher{ AuId = "Au326539", Name = "Bob kajsen", courseId = 1 }).Wait();



            Console.ReadLine();
        }
    }
}
