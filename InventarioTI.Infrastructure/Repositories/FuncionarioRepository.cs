using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using InventarioTI.Infrastructure.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace InventarioTI.Infrastructure.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DbConnection _connection = new DbConnection();

        public List<Funcionario> Listar()
        {
            var lista = new List<Funcionario>();

            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"SELECT F.ID_Funcionario, F.Nome, F.Cargo, F.Email, F.ID_Setor, 
                                  S.Nome_Setor, S.Localizacao 
                           FROM FUNCIONARIOS F
                           LEFT JOIN SETORES S ON F.ID_Setor = S.ID_Setor";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Funcionario
                {
                    ID_Funcionario = (int)reader["ID_Funcionario"],
                    Nome = reader["Nome"].ToString(),
                    Cargo = reader["Cargo"].ToString(),
                    Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                    ID_Setor = reader["ID_Setor"] != DBNull.Value ? (int)reader["ID_Setor"] : (int?)null,
                    SetorNome = reader["Nome_Setor"] != DBNull.Value ? reader["Nome_Setor"].ToString() : "",
                    Localizacao = reader["Localizacao"] != DBNull.Value ? reader["Localizacao"].ToString() : ""
                });
            }
            return lista;
        }




    }
}
