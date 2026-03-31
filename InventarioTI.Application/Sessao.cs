using InventarioTI.Domain.Entities;

namespace InventarioTI.Application
{
    public static class Sessao
    {
        // Variável GLOBAL para a UI consultar quem está logado:
        public static Usuario UsuarioLogado { get; set; }

        public static bool IsAdmin => UsuarioLogado != null && UsuarioLogado.Perfil.ToLower() == "admin";

        public static void Logout()
        {
            UsuarioLogado = null;
        }
    }
}
