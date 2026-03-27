using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using InventarioTI.Infrastructure.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace InventarioTI.Infrastructure.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        private readonly DbConnection _connection = new DbConnection();

        public void Adicionar(Equipamento equipamento)
        {
            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO EQUIPAMENTOS 
            (Nome_Equipamento, Tipo, Data_Aquisicao, ID_Funcionario, Marca) 
            VALUES (@Nome, @Tipo, @Data, @Funcionario,@Marca)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", equipamento.Nome);
            cmd.Parameters.AddWithValue("@Tipo", equipamento.Tipo);
            cmd.Parameters.AddWithValue("@Marca", equipamento.Marca);
            cmd.Parameters.AddWithValue("@Data", equipamento.Data_Aquisicao);
            cmd.Parameters.AddWithValue("@Funcionario", 2);

            cmd.ExecuteNonQuery();
        }

        public List<Equipamento> Listar()
        {
            var lista = new List<Equipamento>();

            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = "SELECT * FROM EQUIPAMENTOS";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Equipamento
                {
                    Id = (int)reader["ID_Equipamento"],
                    Nome = reader["Nome_Equipamento"].ToString(),
                    Tipo = reader["Tipo"].ToString(),
                    Marca = reader["Marca"].ToString(),
                    Data_Aquisicao = (DateTime)reader["Data_Aquisicao"]
                });
            }
            conn.Close();
            return lista;
        }

        
            public void Atualizar(Equipamento equipamento)
        {
            using (var conn = _connection.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE EQUIPAMENTOS 
                       SET Nome_Equipamento = @Nome,
                           Tipo = @Tipo,
                           Marca = @Marca,
                           Data_Aquisicao = @Data,
                           ID_Funcionario = @Funcionario
                       WHERE ID_Equipamento = @ID";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", equipamento.Id);
                    cmd.Parameters.AddWithValue("@Nome", equipamento.Nome);
                    cmd.Parameters.AddWithValue("@Tipo", equipamento.Tipo);
                    cmd.Parameters.AddWithValue("@Marca", equipamento.Marca);
                    cmd.Parameters.AddWithValue("@Data", equipamento.Data_Aquisicao);

                    // ⚠️ coloca um ID válido do funcionário
                    cmd.Parameters.AddWithValue("@Funcionario", 2);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void Remover(int id)
        {
            using (var conn = _connection.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM EQUIPAMENTOS WHERE ID_Equipamento = @Id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}