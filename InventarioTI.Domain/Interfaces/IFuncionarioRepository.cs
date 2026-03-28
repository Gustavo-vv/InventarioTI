using InventarioTI.Domain.Entities;
using System.Collections.Generic;

namespace InventarioTI.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
        void Adicionar(Funcionario funcionario);
        List<Funcionario> Listar();
        void Atualizar(Funcionario funcionario);
        void Remover(int id);
    }
}
