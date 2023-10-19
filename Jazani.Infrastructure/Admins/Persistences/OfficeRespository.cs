using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Jazani.Infrastructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Admins.Persistences
{
    public class OfficeRespository : CrudRepository<Office, int>, IOfficeRepository
    {
        public OfficeRespository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
