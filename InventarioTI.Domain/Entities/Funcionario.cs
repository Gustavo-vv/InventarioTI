namespace InventarioTI.Domain.Entities
{
    public class Funcionario
    {
        public int ID_Funcionario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public int? ID_Setor { get; set; } // Opcional no banco
        
        // Propriedades Helpers trazidas por relacional (JOIN)
        public string SetorNome { get; set; }
        public string Localizacao { get; set; }
        
        public string ResumoSetor => string.IsNullOrEmpty(SetorNome) ? "Sem Setor" : $"{SetorNome} ({Localizacao})";
        public string NomeComSetor => string.IsNullOrEmpty(SetorNome) ? Nome : $"{Nome} - {ResumoSetor}";
    }
}
