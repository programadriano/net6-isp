using API.Entities;

namespace API.Repositories
{
    public interface IBaseLeituraRepository<T> where T : EntityBase
    {
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int id);
    }
}
