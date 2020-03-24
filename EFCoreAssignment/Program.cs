using EFCoreAssignment.Datalayer.QueryRepository;
using System;

namespace EFCoreAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseQueries exerciseQueries = new ExerciseQueries();

            exerciseQueries.GetallExercises();

            Console.WriteLine("\n\n\n");

            exerciseQueries.GetExercisesByStudentId(1);

            Console.ReadLine();
        }
    }
}
