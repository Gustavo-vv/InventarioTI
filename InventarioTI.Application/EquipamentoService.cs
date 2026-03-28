using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace InventarioTI.Application.Services
{
    public class EquipamentoService
    {
        private readonly IEquipamentoRepository _repository;

        public EquipamentoService(IEquipamentoRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(Equipamento equipamento)
        {
            if (string.IsNullOrEmpty(equipamento.Nome))
                throw new Exception("Nome obrigatório");

            VerificarLimiteDeTipo(equipamento);
            _repository.Adicionar(equipamento);
        }

        public List<Equipamento> Listar()
        {
            return _repository.Listar();
        }
    
        public void Atualizar(Equipamento equipamento)
        {
            if (equipamento.Id <= 0)
                throw new Exception("ID inválido");

            VerificarLimiteDeTipo(equipamento);
            _repository.Atualizar(equipamento);
        }

        private void VerificarLimiteDeTipo(Equipamento equipamento)
        {
            if (!equipamento.ID_Funcionario.HasValue) 
                return; // Se não tem dono, pode alocar no estoque infinitamente.

            var itensDoFuncionario = _repository.Listar()
                .FindAll(e => e.ID_Funcionario == equipamento.ID_Funcionario && e.Id != equipamento.Id);

            foreach (var item in itensDoFuncionario)
            {
                if (item.Tipo.Equals(equipamento.Tipo, StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception($"O funcionário já possui um equipamento do tipo '{equipamento.Tipo}' registrado no nome dele.");
                }
            }
        }

        // 🔥 FALTAVA ISSO
        public void Remover(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido");

            _repository.Remover(id);
        }
    }
}
