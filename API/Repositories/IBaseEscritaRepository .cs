using API.Entities;

namespace API.Repositories
{
    public interface IBaseEscritaRepository<T> where T : EntityBase
    {
        void Deletar(int id);
        void Salvar(T obj);
        void Atualizar(T obj);
    }
}
