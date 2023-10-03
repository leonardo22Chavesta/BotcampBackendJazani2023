using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Admins.Persistences
{
    public class OfficeRespository : IOfficeRepository
    {
        private readonly ApplicationDbContext _context;

        public OfficeRespository(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<IReadOnlyList<Office>> FindAllAsync()
        {
            return await _context.Offices.ToListAsync();
        }

        public async Task<Office?> FindByIdAsync(int id)
        {
            return await _context.Offices.FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}
