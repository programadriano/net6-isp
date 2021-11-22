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
        private readonly IBaseEscritaRepository<Noticias> _noticiasEscritaRepository;
        private readonly IBaseLeituraRepository<Noticias> _noticiasLeituraRepository;


        public NoticiaController(ILogger<NoticiaController> logger,
             IBaseEscritaRepository<Noticias> noticiasEscritaRepository,
             IBaseLeituraRepository<Noticias> noticiasLeituraRepository
            )
        {
            _logger = logger;
            _noticiasEscritaRepository = noticiasEscritaRepository;
            _noticiasLeituraRepository = noticiasLeituraRepository;
        }

        [HttpGet(Name = "GetNews")]
        public IEnumerable<Noticias> Get()
        {
            return _noticiasLeituraRepository.BuscarTodos();
        }

        [HttpPost]
        public IActionResult Post(Noticias noticias)
        {
            try
            {
                _noticiasEscritaRepository.Salvar(noticias);
                return StatusCode(201, "Noticia cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}