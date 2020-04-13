using EFCoreAssignment.Datalayer.Configurations;
using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public class CreationRepository<T> : ICreationRepository<T> where T : class
    {
        private readonly DbContext _context;
        public CreationRepository(DbContext context)
        {
            _context = context;
        }

        virtual public async Task<T> AddAsync(T entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch(AggregateException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return entity;
        }

    }
}
