using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using System;

namespace InventarioTI.Application.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario Autenticar(string login, string senha)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
                throw new Exception("Usuário e senha são obrigatórios!");

            var usuario = _repository.Autenticar(login, senha);
            if (usuario == null)
            {
                throw new Exception("Login bloqueado: Acesso negado. Usuário ou senha incorretos.");
            }

            return usuario;
        }
    }
}
