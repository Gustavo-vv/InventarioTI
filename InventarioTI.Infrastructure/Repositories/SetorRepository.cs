using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using InventarioTI.Infrastructure.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace InventarioTI.Infrastructure.Repositories
{
    public class SetorRepository : ISetorRepository
    {
        private readonly DbConnection _connection = new DbConnection();

        public List<Setor> Listar()
        {
            var lista = new List<Setor>();

            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = "SELECT * FROM SETORES";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Setor
                {
                    ID_Setor = (int)reader["ID_Setor"],
                    Nome_Setor = reader["Nome_Setor"].ToString(),
                    Localizacao = reader["Localizacao"].ToString()
                });
            }
            return lista;
        }
    }
}
