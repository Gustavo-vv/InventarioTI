namespace InventarioTI.Domain.Entities
{
    public class Setor
    {
        public int ID_Setor { get; set; }
        public string Nome_Setor { get; set; }
        public string Localizacao { get; set; }
        
        // Propriedade Helper para o ComboBox da UI
        public string NomeCompleto => $"{Nome_Setor} ({Localizacao})";
    }
}
