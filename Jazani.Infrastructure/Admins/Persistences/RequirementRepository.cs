using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Admins.Persistences
{
    public class RequirementRepository : IRequirementRepository
    {
        private readonly ApplicationDbContext _context;

        public RequirementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Requirement>> FindAllAsync()
        {
            return await _context.Requirements.ToListAsync();
        }

        public async Task<Requirement?> FindByIdAsync(int id)
        {
            return await _context.Requirements.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<Requirement> SaveAsync(Requirement requirement)
        {
            EntityState state = _context.Entry(requirement).State;

            _ = state switch
            {
                EntityState.Detached => _context.Requirements.Add(requirement),
                EntityState.Modified => _context.Requirements.Update(requirement),
            };
            await _context.SaveChangesAsync();

            return requirement;
        }
    }
}
