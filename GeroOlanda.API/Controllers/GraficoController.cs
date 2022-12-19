
using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GeroOlanda.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GraficoController : ControllerBase
    {
        private readonly IGraficoService _graficoService;

        public GraficoController(IGraficoService graficoService)
        {
            _graficoService = graficoService;
        }

        [HttpPost]
        [SwaggerOperation("Cadastrar Dados para preencher o Grafico.")]
        [SwaggerResponse(200, "", typeof(List<GraficoDTO>))]
        public IActionResult GravarDadosParaOGrafico(GraficoDTO graficoDados)
        {
            var retorno = _graficoService.GravarDadosParaOGrafico(graficoDados);
            return Ok(retorno);
        }
    }
}