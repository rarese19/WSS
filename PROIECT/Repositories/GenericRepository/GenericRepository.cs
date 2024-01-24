﻿using Microsoft.EntityFrameworkCore;
using PROIECT.Data;
using PROIECT.Models.Base;

namespace PROIECT.Repositories.GenericRepository
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity: BaseEntity
    {
        protected readonly Context _context;

        protected readonly DbSet<TEntity> _table;

        public GenericRepository(Context context)
        {
            _context = context;
            _table = context.Set<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _table.AsNoTracking().ToList();
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }
        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }
        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }
        public bool DeleteById(Guid id)
        {
            var entity = _table.Find(id);
            if (entity == null) return false;
            _table.Remove(entity);
            return true;
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }
        public async Task<TEntity> FindByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
