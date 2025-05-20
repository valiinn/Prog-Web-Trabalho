using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICoordenadorService
    {
        Task<IEnumerable<Coordenador>> ListarTodosAsync();
        Task<Coordenador> ListarPorIdAsync(int id);
        Task AdicionarAsync(Coordenador coordenador);
        Task AlterarAsync(Coordenador coordenador);
        Task ExcluirAsync(int id);
    }
}
