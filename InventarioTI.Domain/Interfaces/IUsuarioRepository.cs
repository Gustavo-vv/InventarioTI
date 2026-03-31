using InventarioTI.Domain.Entities;

namespace InventarioTI.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario Autenticar(string login, string senha);
    }
}
