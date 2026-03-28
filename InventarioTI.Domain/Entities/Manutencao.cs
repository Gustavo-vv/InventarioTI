using System;

namespace InventarioTI.Domain.Entities
{
    public class Manutencao
    {
        public int Registro_Manutencao { get; set; }
        public int ID_Funcionario { get; set; }
        public int ID_Equipamento { get; set; }
        public DateTime Data_Manutencao { get; set; }
        public string Descricao { get; set; }
        
        // Propriedades Helpers trazidas por relacional (JOIN) para GridView
        public string NomeEquipamento { get; set; }
        public string NomeFuncionario { get; set; }
    }
}
