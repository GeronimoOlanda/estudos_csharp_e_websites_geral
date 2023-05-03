using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.WebEncoders.Testing;
using Swashbuckle.AspNetCore.Annotations;

namespace GeroOlanda.API.Controllers.AreaTrabalho
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaTrabalhoController : ControllerBase
    {
        private readonly IAreaTrabalhoService _areaTrabalhoService;

        public AreaTrabalhoController(IAreaTrabalhoService areaTrabalhoService)
        {
            _areaTrabalhoService = areaTrabalhoService;
        }

        [HttpPost]
        [SwaggerOperation("Cadastrar Detalhes Area de Trabalho")]
        [SwaggerResponse(200, "", typeof(List<AreaTrabalhoDTO>))]
        public AreaTrabalhoDTO AreaTrabalhoDetalhes([FromBody] AreaTrabalhoDTO AreaTrabalho)
        {
            var response = _areaTrabalhoService.AreaTrabalhoDetalhes(AreaTrabalho);
            return response;
        }
    }
}