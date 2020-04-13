using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Datalayer.QueryRepository
{
    public interface ICreationRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
    }
}
