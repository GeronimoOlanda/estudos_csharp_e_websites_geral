
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GeroOlanda.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
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
        public IActionResult GravarDadosDescricao(string Descricao)
        {
            var retorno =  _homeService.CadastrarUma(Descricao);
           
            return Ok(retorno);
        }



    }
}