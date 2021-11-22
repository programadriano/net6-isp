namespace API.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Salvar(T obj);
        void Atualizar(T obj);
        T Deletar(int id);
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int id);       
    }


}
