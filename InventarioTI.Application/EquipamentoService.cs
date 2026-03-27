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

            _repository.Atualizar(equipamento);
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
