using InventarioTI.Domain.Entities;
using System.Collections.Generic;

namespace InventarioTI.Domain.Interfaces
{
    public interface IEquipamentoRepository
    {
        void Adicionar(Equipamento equipamento);
        List<Equipamento> Listar();
        void Atualizar(Equipamento equipamento);
        void Remover(int id);
    }
}