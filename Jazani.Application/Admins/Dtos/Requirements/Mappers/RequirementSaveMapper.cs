using AutoMapper;
using Jazani.Domain.Admins.Models;

namespace Jazani.Application.Admins.Dtos.Requirements.Mappers
{
    public class RequirementSaveMapper : Profile
    {
        public RequirementSaveMapper() 
        {
            CreateMap<Requirement, RequirementSaveDto>().ReverseMap();
        }
    }
}
