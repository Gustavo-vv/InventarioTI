namespace InventarioTI.Domain.Entities
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public DateTime Data_Aquisicao { get; set; }
    }
}