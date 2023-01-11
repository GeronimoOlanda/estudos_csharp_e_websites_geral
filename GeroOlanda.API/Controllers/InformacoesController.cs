
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
    public class InformacoesController : ControllerBase
    {
        private readonly IInformacoesService _informacoesService;

        public InformacoesController(IInformacoesService informacoesService)
        {
            _informacoesService = informacoesService;
        }

        [HttpPost]
        [SwaggerOperation("Cadastrar Informações")]
        [SwaggerResponse(200, "", typeof(List<AgendaDTO>))]
        public InformacoesDTO CadastrarInformacoes([FromBody] InformacoesDTO agendaDTO)
        {
            var response = _informacoesService.CadastrarInformacoes(agendaDTO);
            return response;
        }

       
    }
}