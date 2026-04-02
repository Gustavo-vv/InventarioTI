using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace InventarioTI.Application.Services
{
    public class FuncionarioService
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioService(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        public List<Funcionario> Listar()
        {
            return _repository.Listar();
        }
    }
}
