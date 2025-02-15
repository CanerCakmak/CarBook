using CarBook.Application.Interfaces.Repositories;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Common;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async ValueTask DisposeAsync()
            =>await _appDbContext.DisposeAsync();

        public int Save()
            => _appDbContext.SaveChanges();

        public async Task<int> SaveAsync()
            => await _appDbContext.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>()
            => new ReadRepository<T>(_appDbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
            => new WriteRepository<T>(_appDbContext);
    }
}
