using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using InventarioTI.Infrastructure.Data;
using System.Data.SqlClient;

namespace InventarioTI.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbConnection _connection = new DbConnection();

        public Usuario Autenticar(string login, string senha)
        {
            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"
                SELECT u.ID_Usuario, u.Login, u.Perfil, u.ID_Funcionario, f.Nome as NomeFuncionario
                FROM dbo.USUARIOS u
                INNER JOIN dbo.FUNCIONARIOS f ON u.ID_Funcionario = f.ID_Funcionario
                WHERE u.Login = @Login AND u.Senha = @Senha";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Usuario
                {
                    ID_Usuario = (int)reader["ID_Usuario"],
                    Login = reader["Login"].ToString(),
                    Perfil = reader["Perfil"].ToString(),
                    ID_Funcionario = (int)reader["ID_Funcionario"],
                    NomeFuncionario = reader["NomeFuncionario"].ToString()
                };
            }
            return null;
        }
    }
}
