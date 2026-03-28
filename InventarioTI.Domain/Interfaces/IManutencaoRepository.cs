using InventarioTI.Domain.Entities;
using System.Collections.Generic;

namespace InventarioTI.Domain.Interfaces
{
    public interface IManutencaoRepository
    {
        void Adicionar(Manutencao manutencao);
        List<Manutencao> Listar();
        void Remover(int id);
    }
}
