using InventarioTI.Domain.Entities;
using System.Collections.Generic;

namespace InventarioTI.Domain.Interfaces
{
    public interface ISetorRepository
    {
        List<Setor> Listar();
    }
}
