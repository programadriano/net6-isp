using API.Entities;

namespace API.Repositories
{
    public interface IBaseLeituraRepository<T> where T : EntityBase
    {
        void Gravar(T obj);
        void Atualizar(T obj);
    }
}
