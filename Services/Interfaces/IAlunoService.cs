using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> ListarTodosAsync();
        Task<Aluno> ListarPorIdAsync(int id);
        Task AdicionarAsync(Aluno aluno);
        Task AlterarAsync(Aluno aluno);
        Task ExcluirAsync(int id);
    }
}
