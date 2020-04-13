using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using EFCoreAssignment.Datalayer.QueryRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class StudentRepository : CreationRepository<Student>, IStudentRepository
    {
        private readonly OnlinehelpContext _context;
        public StudentRepository(OnlinehelpContext onlinehelpcontext) : base(onlinehelpcontext)
        {
            _context = onlinehelpcontext;
        }
    }
}
