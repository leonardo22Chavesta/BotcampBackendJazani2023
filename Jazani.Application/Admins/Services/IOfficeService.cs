using Jazani.Application.Admins.Dtos.Offices;


namespace Jazani.Application.Admins.Services
{
    public interface IOfficeService
    {
        Task<IReadOnlyList<OfficeDto>> FindAllAsync();
        Task<OfficeDto?> FindByIdAsync(int id);

        Task<OfficeDto> CrearAsync(OfficeSaveDto officeSaveDto);
        Task<OfficeDto> EditAsync(int id, OfficeSaveDto officeSaveDto);

        Task<OfficeDto> DisableAsync(int id);

    }
}
