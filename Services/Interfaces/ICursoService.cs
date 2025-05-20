using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICursoService
    {
        Task<IEnumerable<Curso>> ListarTodosAsync();
        Task<Curso> ListarPorIdAsync(int id);
        Task AdicionarAsync(Curso curso);
        Task AlterarAsync(Curso curso);
        Task ExcluirAsync(int id);
    }
}
