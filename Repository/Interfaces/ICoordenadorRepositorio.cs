﻿using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface ICoordenadorRepositorio
    {
        Task<IEnumerable<Coordenador>> ListarTodosAsync();
        Task<Coordenador> ListarPorIdAsync(int id);
        Task AdicionarAsync(Coordenador coordenador);
        Task AlterarAsync(Coordenador coordenador);
        Task ExcluirAsync(int id);
    }
}
