using CarBook.Application.Interfaces.Repositories;
using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : BaseEntity , new();
        IWriteRepository<T> GetWriteRepository<T>() where T : BaseEntity   , new();
        Task<int> SaveAsync();
        int Save();


    }
}
