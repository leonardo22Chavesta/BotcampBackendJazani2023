using Jazani.Application.Generals.Dtos.MineralTypes;
using Jazani.Application.Generals.Services;
using Microsoft.AspNetCore.Mvc;




namespace Jazani.Api.Controllers.Generals
{
    [Route("api/[controller]")]
    public class MineralTypeController : Controller
    {
        private readonly IMineralTypeService _mineralTypeService;

        public MineralTypeController(IMineralTypeService mineralTypeService)
        {
            _mineralTypeService = mineralTypeService;
        }

        [HttpGet]
        public async Task<IEnumerable<MineralTypeDto>> Get()
        {
            return await _mineralTypeService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<MineralTypeDto> Get(int id)
        {
            return await _mineralTypeService.FindByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Post([FromBody] MineralTypeSaveDto mineralTypeSaveDto)
        {
            
            if(!ModelState.IsValid)
            {
                var rs = ModelState.Where(x => x.Value.Errors.Count > 0).ToArray();

                return Results.BadRequest(rs);
               
            }
            var response = await _mineralTypeService.CrearAsync(mineralTypeSaveDto);
            return Results.Ok(response);

        }

        [HttpPut("{id}")]
        public async Task<MineralTypeDto> Put(int id, [FromBody] MineralTypeSaveDto mineralTypeSaveDto)
        {
            return await _mineralTypeService.EditAsync(id, mineralTypeSaveDto);
        }

        [HttpDelete("{id}")]
        public async Task<MineralTypeDto> Delete(int id)
        {
            return await _mineralTypeService.DisableAsync(id);
        }
    }
}
