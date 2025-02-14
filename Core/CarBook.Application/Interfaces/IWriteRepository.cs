using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces
{
    public interface IWriteRepository<T> where T : BaseEntity
    {
        Task AddAsync (T entity);
        Task AddRangeAsync (IList<T> entities);

        Task<T> UpdateAsync (T entity);

        Task SoftDeleteById(Guid id);
        Task SoftDelete(T entity);

        Task HardDeleteById(Guid id);
        Task HardDelete(T entity);


    }
}
