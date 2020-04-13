using EFCoreAssignment.Datalayer.QueryRepository;
using System;

namespace EFCoreAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciseQueries exerciseQueries = new ExerciseQueries();

            //exerciseQueries.GetallExercises();

            //Console.WriteLine("\n\n\n");

            //exerciseQueries.GetExercisesByStudentId(1);

            OnlinehelpViews View = new OnlinehelpViews();
            //View.GetHelpRequestExercises("Au616639", 1);
            View.AllOpenHelpRequest("Au616638");

            Console.ReadLine();
        }
    }
}
