using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using EFCoreAssignment.Datalayer.QueryRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class ReviewRepository : CreationRepository<Review>, IReviewRepository
    {
        private readonly OnlinehelpContext _context;
        public ReviewRepository(OnlinehelpContext onlinehelpcontext) : base(onlinehelpcontext)
        {
            _context = onlinehelpcontext;
        }
    }
}
