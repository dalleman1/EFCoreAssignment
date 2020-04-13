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

        public List<HelpRequestExercise> GetHelpRequestExercises(string AUID, int courseID)
        {
            Teacher teacher = new Teacher();
            Course course = new Course();
            List<HelpRequestExercise> HelpRequestExerciseList = _context.helpRequestExercises
                                                                    .Select(h =>
                                                                    new HelpRequestExercise
                                                                    {
                                                                        auId = h.auId,
                                                                        helpwhere = h.helpwhere,
                                                                        number = h.number
                                                                    })
                                                                    .ToList();

            return HelpRequestExerciseList;
        }

    }
}
