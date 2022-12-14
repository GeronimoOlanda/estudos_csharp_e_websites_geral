using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository.Impl.GeroDbContext;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GeroOlanda.API.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        private readonly ICadastrarDadosService _cadastrarDadosService;
        public HomeController(IHomeService homeService, ICadastrarDadosService cadastrarDadosService)
        {
            _homeService = homeService;
            _cadastrarDadosService = cadastrarDadosService;
        }

        [HttpGet]
        [SwaggerOperation("Consulta dados da pagina Home")]
        public async Task<ActionResult<IList<HomeDTO>>> ConsultarDados(string idHome, decimal IdUsuario)
        {
          
            var response = await _homeService.ConsultarDadosPorIdUsuario(IdUsuario);
            return Ok(response);
        }

        [HttpPost]
        [SwaggerOperation("Cadastrar Descricao")]
        [SwaggerResponse(200, "", typeof(List<Home>))]
        public async Task<IActionResult> GravarDadosDescricao(string Descricao)
        {
            await _homeService.Cadastrar(Descricao);

            return Ok(_homeService.Cadastrar(Descricao));
        }
     
    }
}