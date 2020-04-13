using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class OnlinehelpViews
    {
        private readonly OnlinehelpContext _context;
        public OnlinehelpViews()
        {
            _context = new OnlinehelpContext();
        }

        public void GetHelpRequestExercises(string AUID, int courseID)
        {
            List<Exercise> ListOfExercises = _context.exercises.Where(e => e.courseId == courseID).ToList();
            List<Teacher> ListOfTeachers = _context.teachers.Where(t => t.AuId == AUID && t.courseId == courseID).ToList();
            List<HelpRequestExercise> ListOfHelpRequests = _context.helpRequestExercises.Select(h => new HelpRequestExercise { helpwhere = h.helpwhere, auId = h.auId, number = h.number }).ToList();

            List<List<HelpRequestExercise>> Result = new List<List<HelpRequestExercise>>();

            foreach (var e in ListOfExercises)
            {
                Result.Add(ListOfHelpRequests.Where(h => h.number == e.number).ToList());
            }

            foreach (var list in Result)
            {
                foreach (var element in list)
                {
                    System.Console.WriteLine($"Student: {element.auId} needs help with exericse {element.number} at: {element.helpwhere}");
                }
            }

            return;
        }

        public void AllOpenHelpRequest(string AUID)
        {
            List<HelpRequestExercise> helpRequestsExerciseList = _context.helpRequestExercises.Where(h => h.auId == AUID).ToList();
            List<HelpRequest> helpRequestsList = _context.helprequests.Where(h => h.auId == AUID).ToList();

            System.Console.WriteLine($"{AUID}, needs help with the following exercises: \n");
            
            foreach(var element in helpRequestsExerciseList)
            {
                System.Console.WriteLine($"Exercise number: {element.number}\nWhere: {element.helpwhere} \n");
            }

            System.Console.WriteLine("And the following assignments: \n");

            foreach(var element in helpRequestsList)
            {
                System.Console.WriteLine($"Assignment number: {element.assignmentId}");
            }

            return;
        }

        public void PrintAllCourseStatistics()
        {
            List<int> CourseIDs = _context.courses.Select(c => c.courseId).ToList();
            
            foreach(var id in CourseIDs)
            {
                var temp = _context.exercises.Where(e => e.courseId == id).ToList();
                int count = 0;
                
                foreach (var e in temp)
                {
                    var list = _context.helpRequestExercises.Where(d => d.number == e.number).ToList();

                    count = count + list.Count;
                }

                System.Console.WriteLine($"Amount of help requests in exercises for couseId: {id}: {count}");
            }
         
            return;
        }
    }
}
