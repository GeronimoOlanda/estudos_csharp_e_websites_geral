
using GeroOlanda.Domain.Entities;
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

        [HttpPost]
        [SwaggerOperation("Cadastrar Descricao")]
        [SwaggerResponse(200, "", typeof(List<Home>))]
        public IActionResult GravarDadosDescricao(string descricao)
        {
            var retorno =  _homeService.CadastrarUma(descricao);
           

            return Ok(retorno);
        }



    }
}