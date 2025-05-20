using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Repository.Implemetations
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly SQLServerDbContext _context;

        public AlunoRepositorio(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Aluno aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            await _context.SaveChangesAsync();
        }


        public async Task ExcluirAsync(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno != null) {
                _context.Alunos.Remove(aluno);
                await _context.SaveChangesAsync();
            } 
        }

        public async Task<Aluno> ListarPorIdAsync(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task<IEnumerable<Aluno>> ListarTodosAsync()
        {
            return await _context.Alunos.ToListAsync();
        }
    }
}
