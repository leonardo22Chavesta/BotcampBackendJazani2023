using Jazani.Application.Admins.Dtos.Requirements;
using Jazani.Application.Admins.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jazani.Api.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequirementController : Controller
    {
        private readonly IRequirementService _requirementService;

        public RequirementController(IRequirementService requirementService)
        {
            _requirementService = requirementService;
        }

        [HttpGet]
        public async Task<IEnumerable<RequirementDto>> Get()
        {
            return await _requirementService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<RequirementDto> Get(int id)
        {
            return await _requirementService.FindByIdAsync(id);
        }

        [HttpPost]
        public async Task<RequirementDto> Post([FromBody] RequirementSaveDto requirementSaveDto)
        {
            return await _requirementService.CrearAsync(requirementSaveDto);
        }

        [HttpPut]
        public async Task<RequirementDto> Put(int id, [FromBody] RequirementSaveDto requirementSaveDto)
        {
            return await _requirementService.EditAsync(id, requirementSaveDto);
        }

        [HttpDelete]
        public async Task<RequirementDto> Delete(int id)
        {
            return await _requirementService.DisableAsync(id);
        }
    }
}
