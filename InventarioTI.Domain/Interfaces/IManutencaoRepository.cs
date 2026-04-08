using System.Collections.Generic;
using InventarioTI.Domain.Entities;

namespace InventarioTI.Domain.Interfaces
{
    public interface IManutencaoRepository
    {
        void Adicionar(Manutencao manutencao);
        
        List<Manutencao> Listar();
        
        
    }
}
