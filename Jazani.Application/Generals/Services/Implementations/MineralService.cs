using AutoMapper;
using Jazani.Application.Generals.Dtos.Minerals;
using Jazani.Domain.Generals.Models;
using Jazani.Domain.Generals.Repositories;

namespace Jazani.Application.Generals.Services.Implementations
{
    public class MineralService : IMineralService
    {

        private readonly IMineralRepository _repositoryMineral;
        private readonly IMapper _mapper;

        public MineralService(IMineralRepository repositoryMineral, IMapper mapper)
        {
            _repositoryMineral = repositoryMineral;
            _mapper = mapper;
        }

        public async Task<MineralDto> CrearAsync(MineralSaveDto mineralSaveDto)
        {
            Mineral mineral = _mapper.Map<Mineral>(mineralSaveDto);

            mineral.RegistrationDate = DateTime.Now;
            mineral.State = true;

            await _repositoryMineral.SaveAsync(mineral);

            return _mapper.Map<MineralDto>(mineral);
        }

        public async Task<MineralDto> DisableAsync(int id)
        {
            Mineral mineral = await _repositoryMineral.FindByIdAsync(id);
            mineral.State = false;

            await _repositoryMineral.SaveAsync(mineral);

            return _mapper.Map<MineralDto>(mineral);
        }

        public async Task<MineralDto> EditAsync(int id, MineralSaveDto mineralSaveDto)
        {
            Mineral mineral = await _repositoryMineral.FindByIdAsync(id);

            _mapper.Map<MineralSaveDto, Mineral>(mineralSaveDto, mineral);


            await _repositoryMineral.SaveAsync(mineral);

            return _mapper.Map<MineralDto>(mineral);
        }

        public async Task<IReadOnlyList<MineralDto>> FindAllAsync()
        {
            IReadOnlyList<Mineral> minerals = await _repositoryMineral.FindAllAsync();

            return _mapper.Map<IReadOnlyList<MineralDto>>(minerals);
        }

        public async Task<MineralDto?> FindByIdAsync(int id)
        {
            Mineral mineral = await _repositoryMineral.FindByIdAsync(id);

            return _mapper.Map<MineralDto>(mineral);
        }
    }
}
