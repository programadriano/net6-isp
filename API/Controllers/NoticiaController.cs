using API.Entities;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoticiaController : ControllerBase
    {

        private readonly ILogger<NoticiaController> _logger;
        private readonly NoticiasRepository _noticiasRepository;

        public NoticiaController(ILogger<NoticiaController> logger, NoticiasRepository noticiasRepository)
        {
            _logger = logger;
            _noticiasRepository = noticiasRepository;
        }

        [HttpGet(Name = "GetNews")]
        public IEnumerable<Noticias> Get()
        {
            return _noticiasRepository.BuscarTodos();
        }

        [HttpPost]
        public IActionResult Post(Noticias noticias)
        {
            try
            {
                _noticiasRepository.Gravar(noticias);
                return StatusCode(201, "Noticia cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}