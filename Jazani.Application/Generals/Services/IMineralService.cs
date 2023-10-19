﻿using Jazani.Application.Generals.Dtos.Minerals;

namespace Jazani.Application.Generals.Services
{
    public interface IMineralService
    {
       
        Task<IReadOnlyList<MineralDto>> FindAllAsync();
        Task<MineralDto?> FindByIdAsync(int id);
        Task<MineralDto> CrearAsync(MineralSaveDto mineralSaveDto);
        Task<MineralDto> EditAsync(int id, MineralSaveDto mineralSaveDto);
        Task<MineralDto> DisableAsync(int id);
         
    }
}
