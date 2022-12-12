using Microsoft.AspNetCore.Mvc;

namespace GeroOlanda.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Controladora da Pagina Inicial")]
        public string Get()
        {
            return "Ola";
        }
    }
}