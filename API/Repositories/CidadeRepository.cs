using API.Entities;

namespace API.Repositories
{
    public class CidadeRepository : IBaseLeituraRepository<Cidade>
    {
        private static IList<Cidade> _cidade = new List<Cidade>();

        public Cidade BuscarPorId(int id) => _cidade.FirstOrDefault(c => c.Id == id);

        public IEnumerable<Cidade> BuscarTodos()
        {
            return _cidade.ToList();
        }
    }
}
