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

            Teacher t = new Teacher { AuId = "Au12323", courseId = 1, Name = "Bjørn" };
            teacher.AddAsync(t).Wait();
            


            Console.ReadLine();
        }
    }
}
