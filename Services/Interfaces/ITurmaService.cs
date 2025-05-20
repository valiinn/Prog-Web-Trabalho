﻿using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ITurmaService
    {
        Task<IEnumerable<Turma>> ListarTodosAsync();
        Task<Turma> ListarPorIdAsync(int id);
        Task AdicionarAsync(Turma turma);
        Task AlterarAsync(Turma turma);
        Task ExcluirAsync(int id);
    }
}
