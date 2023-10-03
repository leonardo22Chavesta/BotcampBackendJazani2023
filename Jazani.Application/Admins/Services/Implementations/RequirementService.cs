using AutoMapper;
using Jazani.Application.Admins.Dtos.Requirements;
using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;

namespace Jazani.Application.Admins.Services.Implementations
{
    public class RequirementService : IRequirementService 
    {
        private readonly IRequirementRepository _requirementRepository;
        private readonly IMapper _mapper;

        public RequirementService(IRequirementRepository requirementRepository, IMapper mapper)
        {
            _requirementRepository = requirementRepository;
            _mapper = mapper;
        }

        public async Task<RequirementDto> CrearAsync(RequirementSaveDto requirementSaveDto)
        {
            Requirement requirement = _mapper.Map<Requirement>(requirementSaveDto);

            requirement.RegistrationDate = DateTime.Now;
            requirement.State = true;

            Requirement requirementSave = await _requirementRepository.SaveAsync(requirement);

            return _mapper.Map<RequirementDto>(requirementSave);
        }

        public async Task<RequirementDto> DisableAsync(int id)
        {
            Requirement requirement = await _requirementRepository.FindByIdAsync(id);

            requirement.State = false;

            Requirement requirementSave = await _requirementRepository.SaveAsync(requirement);

            return _mapper.Map<RequirementDto>(requirementSave);
        }

        public async Task<RequirementDto> EditAsync(int id, RequirementSaveDto requirementSaveDto)
        {
            Requirement requirement = await _requirementRepository.FindByIdAsync(id);

            _mapper.Map<RequirementSaveDto, Requirement>(requirementSaveDto, requirement);

            Requirement requirementSave = await _requirementRepository.SaveAsync(requirement);

            return _mapper.Map<RequirementDto>(requirementSave);
        }

        public async Task<IReadOnlyList<RequirementDto>> FindAllAsync()
        {
            IReadOnlyList<Requirement> requirement = await _requirementRepository.FindAllAsync();
            IList<RequirementDto> requirementDto = new List<RequirementDto>();

            foreach (var item in requirement)
            {
                requirementDto.Add(new()
                {
                    Id = item.Id,
                });
            }

            return _mapper.Map<IReadOnlyList<RequirementDto>>(requirement);
        }

        public async Task<RequirementDto?> FindByIdAsync(int id)
        {
            Requirement? requirement = await _requirementRepository.FindByIdAsync(id);

            return _mapper.Map<RequirementDto>(requirement);
        }
    }
}
