using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using EFCoreAssignment.Datalayer.QueryRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class HelpRequestRepository : CreationRepository<HelpRequest>, IHelpRequestRepository
    {
        private readonly OnlinehelpContext _context;
        public HelpRequestRepository(OnlinehelpContext onlinehelpcontext) : base(onlinehelpcontext)
        {
            _context = onlinehelpcontext;
        }
    }
}
