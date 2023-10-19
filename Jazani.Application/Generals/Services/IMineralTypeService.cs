using Jazani.Application.Generals.Dtos.MineralTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Application.Generals.Services
{
    public interface IMineralTypeService
    {
        Task<IReadOnlyList<MineralTypeDto>> FindAllAsync();
        Task<MineralTypeDto?> FindByIdAsync(int id);
        Task<MineralTypeDto> CrearAsync(MineralTypeSaveDto mineralTypeSaveDto);
        Task<MineralTypeDto> EditAsync(int id, MineralTypeSaveDto mineralTypeSaveDto);
        Task<MineralTypeDto> DisableAsync(int id);
     }
}
