using System;

namespace InventarioTI.Domain.Entities
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public DateTime Data_Aquisicao { get; set; }
        public int? ID_Funcionario { get; set; } // Pode ser anulável se estiver "no estoque"

        // Helper string
        public string NomeFuncionarioResponsavel { get; set; }
    }
}