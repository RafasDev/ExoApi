using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exo.WebApi.Repositories;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        private readonly ILogger<ProjetoController> _logger;

        public ProjetoController(ProjetoRepository projetoRepository, ILogger<ProjetoController> logger)
        {
            _projetoRepository = projetoRepository;
            _logger = logger;
        }

   
        [HttpGet]
        public IActionResult Listar()
        {
            _logger.LogInformation("Listando todos os projetos...");
            return Ok(_projetoRepository.Listar());
        }
    }
}
