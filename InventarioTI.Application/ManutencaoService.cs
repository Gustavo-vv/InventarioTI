using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace InventarioTI.Application.Services
{
    public class ManutencaoService
    {
        private readonly IManutencaoRepository _repository;

        public ManutencaoService(IManutencaoRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(Manutencao manutencao)
        {
            if (manutencao.ID_Equipamento <= 0)
                throw new Exception("Equipamento obrigatório.");
            if (manutencao.ID_Funcionario <= 0)
                throw new Exception("Funcionário responsável obrigatório.");

            _repository.Adicionar(manutencao);
        }

        public List<Manutencao> Listar()
        {
            return _repository.Listar();
        }

        public void Remover(int id)
        {
            if (id <= 0) throw new Exception("ID inválido");
            _repository.Remover(id);
        }
    }
}
