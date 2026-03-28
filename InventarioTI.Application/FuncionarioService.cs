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

        public void Adicionar(Funcionario funcionario)
        {
            if (string.IsNullOrEmpty(funcionario.Nome))
                throw new Exception("Nome é obrigatório.");

            _repository.Adicionar(funcionario);
        }

        public List<Funcionario> Listar()
        {
            return _repository.Listar();
        }

        public void Atualizar(Funcionario funcionario)
        {
            if (funcionario.ID_Funcionario <= 0)
                throw new Exception("ID do funcionário é inválido.");

            _repository.Atualizar(funcionario);
        }

        public void Remover(int id)
        {
            if (id <= 0) throw new Exception("ID inválido");
            _repository.Remover(id);
        }
    }
}
