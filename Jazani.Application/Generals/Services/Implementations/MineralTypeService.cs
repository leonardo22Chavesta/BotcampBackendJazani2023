using Jazani.Application.Generals.Dtos.MineralTypes;
using AutoMapper;
using Jazani.Domain.Generals.Models;
using Jazani.Domain.Generals.Repositories;

namespace Jazani.Application.Generals.Services.Implementations
{
    public class MineralTypeService : IMineralTypeService
    {
        public readonly IMineralTypeRepository _repositoryRepositories;
        public readonly IMapper _mapper;
        public MineralTypeService( IMineralTypeRepository mineralTypeRepositories, IMapper mapper ) 
        {
            _repositoryRepositories = mineralTypeRepositories;
            _mapper = mapper;
        }

        public async Task<MineralTypeDto> CrearAsync(MineralTypeSaveDto mineralTypeSaveDto)
        {
            MineralType mineralType = _mapper.Map<MineralType>(mineralTypeSaveDto);
            mineralType.RegistrationDate = DateTime.Now;
            mineralType.State = true;

            await _repositoryRepositories.SaveAsync(mineralType);
            
            return _mapper.Map<MineralTypeDto>(mineralType);
        }

        public async Task<MineralTypeDto> DisableAsync(int id)
        {
            MineralType mineralType = await  _repositoryRepositories.FindByIdAsync(id);

            mineralType.State = false;
            
            await _repositoryRepositories.SaveAsync(mineralType);
            
            return _mapper.Map<MineralTypeDto>(mineralType);
        }

        public async Task<MineralTypeDto> EditAsync(int id, MineralTypeSaveDto mineralTypeSaveDto)
        {
            MineralType mineralType = await _repositoryRepositories.FindByIdAsync(id);

            _mapper.Map<MineralTypeSaveDto, MineralType>(mineralTypeSaveDto, mineralType);

            await _repositoryRepositories.SaveAsync(mineralType);

            return _mapper.Map<MineralTypeDto>(mineralType);
        }

        public async Task<IReadOnlyList<MineralTypeDto>> FindAllAsync()
        {
            IReadOnlyList<MineralType> mineralTypes = await _repositoryRepositories.FindAllAsync();

            return _mapper.Map<IReadOnlyList<MineralTypeDto>>(mineralTypes);
        }

        public async Task<MineralTypeDto?> FindByIdAsync(int id)
        {
            MineralType mineralType = await _repositoryRepositories.FindByIdAsync(id);


            return _mapper.Map<MineralTypeDto>(mineralType);
        }
    }
}
