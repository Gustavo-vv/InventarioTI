using System;
using System.Linq;
using InventarioTI.Application.Services;
using InventarioTI.Domain.Entities;
using InventarioTI.Infrastructure.Repositories;

class Program
{
    static void Main()
    {
        var repo = new EquipamentoRepository();
        var service = new EquipamentoService(repo);

        var eq = new Equipamento
        {
            Nome = "CAIO ",
            Tipo = "CADW",
            Marca = "NIKE",
            Data_Aquisicao = DateTime.Now
        };

        service.Adicionar(eq);

        var lista = service.Listar();

        foreach (var item in lista)
        {
            Console.WriteLine(item.Nome);
        }

        if (lista.Count > 0)
        {
            var atualizar = lista.First();

            atualizar.Nome = "PC Atualizado";

            service.Atualizar(atualizar);
            Console.WriteLine("\n Atualizado!");
        }
    }
}