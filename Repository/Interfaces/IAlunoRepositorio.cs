using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface IAlunoRepositorio
    {
        Task<IEnumerable<Aluno>> ListarTodosAsync();
        Task<Aluno> ListarPorIdAsync(int id);
        Task AdicionarAsync(Aluno aluno);
        Task AlterarAsync(Aluno aluno);
        Task ExcluirAsync(int id);

    }
}
