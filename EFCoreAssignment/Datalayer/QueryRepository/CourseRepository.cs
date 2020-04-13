using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using EFCoreAssignment.Datalayer.QueryRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class CourseRepository : CreationRepository<Course>, ICourseRepository
    {
        private readonly OnlinehelpContext _context;
        public CourseRepository(OnlinehelpContext onlinehelpcontext) : base(onlinehelpcontext)
        {
            _context = onlinehelpcontext;
        }
    }
}
