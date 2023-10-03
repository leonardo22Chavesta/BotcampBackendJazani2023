using Jazani.Application.Admins.Dtos.Requirements;


namespace Jazani.Application.Admins.Services
{
    public interface IRequirementService
    {
        Task<IReadOnlyList<RequirementDto>> FindAllAsync();
        Task<RequirementDto?> FindByIdAsync(int id);

        Task<RequirementDto> CrearAsync(RequirementSaveDto requirementSaveDto);
        Task<RequirementDto> EditAsync(int id, RequirementSaveDto requirementSaveDto);
        Task<RequirementDto> DisableAsync(int id);
    }
}
