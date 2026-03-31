using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace InventarioTI.Application.Services
{
    public class ManutencaoService
    {
        private readonly IManutencaoRepository _repository;

        // Regra de negócio: ID fixo do Técnico padrão
        private const int TECNICO_PADRAO_ID = 4;

        public ManutencaoService(IManutencaoRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(Manutencao manutencao)
        {
            if (string.IsNullOrEmpty(manutencao.Descricao))
                throw new Exception("Descrição da manutenção é obrigatória.");
            
            if (manutencao.ID_Equipamento <= 0)
                throw new Exception("Equipamento inválido.");

            // Atribui o técnico padrão se não vier preenchido
            if (manutencao.ID_Funcionario <= 0)
            {
                manutencao.ID_Funcionario = TECNICO_PADRAO_ID;
            }

            _repository.Adicionar(manutencao);
        }

        public List<Manutencao> Listar()
        {
            return _repository.Listar();
        }

        public List<Manutencao> ListarPorEquipamento(int equipamentoId)
        {
            if (equipamentoId <= 0)
                throw new Exception("ID do equipamento inválido.");

            return _repository.ListarPorEquipamento(equipamentoId);
        }

        public void Atualizar(Manutencao manutencao)
        {
            if (manutencao.Registro_Manutencao <= 0)
                throw new Exception("ID de registro de manutenção inválido.");

            if (string.IsNullOrEmpty(manutencao.Descricao))
                throw new Exception("Descrição da manutenção é obrigatória.");

            _repository.Atualizar(manutencao);
        }

        public void Remover(int registroManutencaoId)
        {
            if (registroManutencaoId <= 0)
                throw new Exception("ID de registro de manutenção inválido.");

            _repository.Remover(registroManutencaoId);
        }
    }
}
