using API.Entities;

namespace API.Repositories
{

    public class NoticiasRepository : IBaseEscritaRepository<Noticias>, IBaseLeituraRepository<Noticias>
    {

        private static IList<Noticias> _noticias = new List<Noticias>();

        public void Atualizar(Noticias obj)
        {
            var noticia = BuscarPorId(obj.Id);
            noticia.Titulo = obj.Titulo;
        }

        public Noticias BuscarPorId(int id) => _noticias.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Noticias> BuscarTodos()
        {
            return _noticias.ToList();
        }

        public void Deletar(int id)
        {
            var noticia = BuscarPorId(id);
            _noticias.Remove(noticia);
        }

        public void Gravar(Noticias obj)
        {
            _noticias.Add(obj);
        }
    }
}
