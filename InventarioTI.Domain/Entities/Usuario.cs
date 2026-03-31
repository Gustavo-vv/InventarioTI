namespace InventarioTI.Domain.Entities
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; } // "Admin" ou "Comum"
        public int ID_Funcionario { get; set; }
        
        // Atributo Extra (usado na memória para carregar o nome verdadeiro da pessoa no painel "Olá, XXXX")
        public string NomeFuncionario { get; set; }
    }
}
