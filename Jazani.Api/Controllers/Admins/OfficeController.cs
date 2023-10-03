using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jazani.Domain.Admins.Repositories;
using Jazani.Domain.Admins.Models;
using Jazani.Application.Admins.Services;
using Jazani.Application.Admins.Dtos.Offices;

namespace Jazani.Api.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : Controller
    {
        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        [HttpGet]
        public async Task<IEnumerable<OfficeDto>> Get()
        {
            return await _officeService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<OfficeDto> Get(int id)
        {
            return await _officeService.FindByIdAsync(id);
        }

        [HttpPost]
        public void Post([FromBody] Office entity) { }



    }
}
