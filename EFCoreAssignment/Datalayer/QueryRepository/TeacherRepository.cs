using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class TeacherRepository : CreationRepository<Teacher>, ITeacherRepository
    {
        private readonly OnlinehelpContext _context;
        public TeacherRepository(OnlinehelpContext onlinehelpcontext) :base(onlinehelpcontext)
        {
            _context = onlinehelpcontext;
        }
    }
}
