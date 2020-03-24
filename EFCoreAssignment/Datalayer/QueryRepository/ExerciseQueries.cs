using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class ExerciseQueries
    {
        private readonly OnlinehelpContext _context;
        public ExerciseQueries()
        {
            _context = new OnlinehelpContext();
        }

        public List<Exercise> GetallExercises()
        {
            List<Exercise> ExerciseList = _context.exercises
                                         .Select(e =>
                                         new Exercise
                                         {
                                             exerciseId = e.exerciseId,
                                             lecture = e.lecture,
                                             number = e.number,
                                             studentId = e.studentId,
                                             helpwhere = e.helpwhere,
                                             teacherId = e.teacherId,
                                             helprequestId = e.helprequestId
                                         })
                                         .ToList();
            foreach (var Exercise in ExerciseList)
            {
                Console.WriteLine($" ExerciseID: {Exercise.exerciseId}, Lecture: {Exercise.lecture}, Number: {Exercise.number}, StudentId: {Exercise.studentId} \n");
            }
            return ExerciseList;
        }

        public List<Exercise> GetExercisesByStudentId(int studentId)
        {
            List<Exercise> ExerciseList = _context.exercises
                                         .Where(e => e.studentId == studentId)
                                         .Select(e =>
                                         new Exercise
                                         {
                                             exerciseId = e.exerciseId,
                                             lecture = e.lecture,
                                             number = e.number,
                                             studentId = e.studentId,
                                             helpwhere = e.helpwhere,
                                             teacherId = e.teacherId,
                                             helprequestId = e.helprequestId
                                         })
                                         .ToList();
            foreach (var Exercise in ExerciseList)
            {
                Console.WriteLine($" ExerciseID: {Exercise.exerciseId}, Lecture: {Exercise.lecture}, Number: {Exercise.number}, StudentId: {Exercise.studentId} \n");
            }
            return ExerciseList;
        }
    }
}
