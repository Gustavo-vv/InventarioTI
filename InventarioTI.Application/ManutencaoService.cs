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
            if (string.IsNullOrEmpty(manutencao.Descricao))
                throw new Exception("Descrição da manutenção é obrigatória.");

            if (manutencao.ID_Equipamento <= 0)
                throw new Exception("Equipamento inválido.");

            

            _repository.Adicionar(manutencao);
        }

        public List<Manutencao> Listar()
        {
            return _repository.Listar();
        }

        


    }
}
