using API.Entities;

namespace API.Repositories
{
    public interface IBaseEscritaRepository<T> where T : EntityBase
    {
        void Deletar(int id);
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int id);
    }
}
