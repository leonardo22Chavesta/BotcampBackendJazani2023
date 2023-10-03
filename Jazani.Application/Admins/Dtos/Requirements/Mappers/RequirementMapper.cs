using AutoMapper;
using Jazani.Domain.Admins.Models;

namespace Jazani.Application.Admins.Dtos.Requirements.Mappers
{
    public class RequirementMapper : Profile
    {
       public RequirementMapper() 
        {
            CreateMap<Requirement, RequirementDto>();
        }
    }
}
