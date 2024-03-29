
using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.WebEncoders.Testing;
using Swashbuckle.AspNetCore.Annotations;

namespace GeroOlanda.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaService _agendaService;

        public AgendaController(IAgendaService agendaService)
        {
            _agendaService = agendaService;
        }

        [HttpPost]
        [SwaggerOperation("Cadastrar dados Agenda")]
        [SwaggerResponse(200, "", typeof(List<AgendaDTO>))]
        public AgendaDTO CriarDadosAgenda([FromBody]AgendaDTO agendaDTO)
        {
            var response = _agendaService.CriarDadosAgenda(agendaDTO);
            return response;
        }

        [HttpGet]
        [SwaggerOperation("Retornando dados da agenda com a flag ativa ou n�o")]
        public IList<AgendaDTO> RetornoDados(int idUsuario)
        {
            var response = _agendaService.RetornoDados(idUsuario);

            return response;

        }

        [HttpDelete]
        public IActionResult RemoveDaBase(int idUsuario)
        {
            var response = _agendaService.RemoveDaBase(idUsuario);
            return Ok(response);
        }
    }
}