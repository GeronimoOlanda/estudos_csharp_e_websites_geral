
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

        //[HttpGet]
        //[SwaggerOperation("Consultar dados da Base")]
        //public IList<AgendaDTO> ConsultarDadosAgenda(int idIntervencao, string Descricao)
        //{
        //    var response = _agendaService.ConsultarDadosAgenda(idIntervencao, Descricao);

        //    return response;
        //}

        [HttpGet]
        [SwaggerOperation("Retornando dados da agenda com a flag ativa ou não")]
        public IList<AgendaDTO> RetornoDadosFlag(string flag)
        {
            var response = _agendaService.RetornoDadosFlag(flag);

            return response;

        }
    }
}