using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface ITurmaRepositorio
    {
        Task<IEnumerable<Turma>> ListarTodosAsync();
        Task<Turma> ListarPorIdAsync(int id);
        Task AdicionarAsync(Turma turma);
        Task AlterarAsync(Turma turma);
        Task ExcluirAsync(int id);
    }
}
