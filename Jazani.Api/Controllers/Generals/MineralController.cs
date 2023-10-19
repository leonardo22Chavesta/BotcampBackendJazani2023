using Jazani.Application.Generals.Dtos.Minerals;
using Jazani.Application.Generals.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jazani.Api.Controllers.Generals
{
    [Route("api/[controller]")]
    public class MineralController : Controller
    {
        
         private readonly IMineralService _mineralService;

          public MineralController(IMineralService mineralService)
          {
              _mineralService = mineralService;
          }

          [HttpGet]
          public async Task<IEnumerable<MineralDto>> Get()
          {
              return await _mineralService.FindAllAsync();
          }

          [HttpGet("{id}")]
          public async Task<MineralDto> Get(int id)
          {
              return await _mineralService.FindByIdAsync(id);
          }

          [HttpPost]
          public async Task<MineralDto> Post([FromBody] MineralSaveDto mineralSaveDto)
          {
              return await  _mineralService.CrearAsync(mineralSaveDto);
          }

          [HttpPut("{id}")]
          public async Task<MineralDto> Put(int id, [FromBody] MineralSaveDto mineralSaveDto)
          {
              return await _mineralService.EditAsync(id, mineralSaveDto);
          }

          [HttpDelete("{id}")]
          public async Task<MineralDto> Delete(int id)
          {
              return await _mineralService.DisableAsync(id);
          }


         
    }
}
