using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using System.Collections.Generic;

namespace InventarioTI.Application.Services
{
    public class SetorService
    {
        private readonly ISetorRepository _repository;

        public SetorService(ISetorRepository repository)
        {
            _repository = repository;
        }

        public List<Setor> Listar()
        {
            return _repository.Listar();
        }
    }
}
