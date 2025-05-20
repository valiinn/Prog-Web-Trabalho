using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface IInstrutorRepositorio
    {
        Task<IEnumerable<Instrutor>> ListarTodosAsync();
        Task<Instrutor> ListarPorIdAsync(int id);
        Task AdicionarAsync(Instrutor instrutor);
        Task AlterarAsync(Instrutor instrutor);
        Task ExcluirAsync(int id);
    }
}
