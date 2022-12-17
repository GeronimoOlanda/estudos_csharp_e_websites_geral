
using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GeroOlanda.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserLoginController : ControllerBase
    {
        private readonly ILoginUserService _loginUserService;

        public UserLoginController(ILoginUserService loginUserService)
        {
            _loginUserService = loginUserService;
        }

        [HttpGet]
        [SwaggerOperation("Consultar usuario cadastrado por Id")]
        public IActionResult ConsultarCadastroPorId(int id)
        {
            var response = _loginUserService.ConsultarCadastroPorId(id);
            return Ok(response);

        }

        [HttpPost]
        [SwaggerOperation("Cadastrar Descricao")]
        [SwaggerResponse(200, "", typeof(List<UserLogin>))]
        public IActionResult CadastrarDadosLogin([FromBody]UserLogin userLogin)
        {
           var dadoslogin = _loginUserService.CadastrarDadosLogin(userLogin);
            return Ok(dadoslogin);
        }



    }
}