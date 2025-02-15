using CarBook.Application.Interfaces.Repositories;
using CarBook.Domain.Common;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;

        public WriteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        private DbSet<T> Table { get => _appDbContext.Set<T>(); }
        public async Task AddAsync(T entity)
            => await Table.AddAsync(entity);

        public async Task AddRangeAsync(IList<T> entities)
            => await Table.AddRangeAsync(entities);

        public async Task<T> UpdateAsync(T entity)
        {
           await Task.Run(() => Table.Update(entity));
            return entity;
        }
        public async Task HardDelete(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task HardDeleteById(Guid id)
        {
            var entity = await Table.FindAsync(id);
            if (entity != null)
            {
                Table.Remove(entity);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task SoftDelete(T entity)
        {
            if (entity is not null)
            {
                entity.IsDeleted = true;
                await Task.Run(() => Table.Update(entity));
            }
        }

        public async Task SoftDeleteById(Guid id)
        {
            var entity = await Table.FindAsync(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                await Task.Run(() => Table.Update(entity));
            }
        }

        
    }
}
