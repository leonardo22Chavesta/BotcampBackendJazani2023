using Jazani.Domain.Cores.Repositories;
using Jazani.Domain.Generals.Models;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Cores.Persistences
{
    public abstract class CrudRepository<T, ID> : ICrudRespository<T, ID> where T : class
    {
        public readonly ApplicationDbContext _context;

        public CrudRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual  async Task<IReadOnlyList<T>> FindAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<T?> FindByIdAsync(ID id)
        {
            return await _context.Set<T>().FindAsync(id); ;
        }

        public virtual async Task<T> SaveAsync(T entity)
        {
            EntityState state = _context.Entry(entity).State;

            _ = state switch
            {
                EntityState.Detached => _context.Set<T>().Add(entity),
                EntityState.Modified => _context.Set<T>().Update(entity),
            };

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
