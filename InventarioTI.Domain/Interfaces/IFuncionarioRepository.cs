using InventarioTI.Domain.Entities;
using System.Collections.Generic;

namespace InventarioTI.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
   
        List<Funcionario> Listar();
        
        
    }
}
