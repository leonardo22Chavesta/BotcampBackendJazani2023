
using Jazani.Domain.Admins.Models;

namespace Jazani.Domain.Admins.Repositories
{
    public interface IRequirementRepository
    {
        Task<IReadOnlyList<Requirement>> FindAllAsync();
        Task<Requirement?> FindByIdAsync(int id);
        Task<Requirement> SaveAsync(Requirement requirement);
    }
}
