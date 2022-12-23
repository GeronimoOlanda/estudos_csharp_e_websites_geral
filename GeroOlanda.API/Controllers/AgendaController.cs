
using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
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
            return null;
        }
    }
}