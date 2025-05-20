using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IInstrutorService
    {
        Task<IEnumerable<Instrutor>> ListarTodosAsync();
        Task<Instrutor> ListarPorIdAsync(int id);
        Task AdicionarAsync(Instrutor instrutor);
        Task AlterarAsync(Instrutor instrutor);
        Task ExcluirAsync(int id);
    }
}
