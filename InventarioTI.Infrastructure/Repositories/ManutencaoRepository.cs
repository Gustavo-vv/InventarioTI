using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using InventarioTI.Infrastructure.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace InventarioTI.Infrastructure.Repositories
{
    public class ManutencaoRepository : IManutencaoRepository
    {
        private readonly DbConnection _connection = new DbConnection();

        public void Adicionar(Manutencao manutencao)
        {
            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO MANUTENCAO (ID_Funcionario, ID_Equipamento, Data_Manutencao, Descricao) 
                           VALUES (@IDFunc, @IDEquip, @Data, @Desc)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFunc", manutencao.ID_Funcionario);
            cmd.Parameters.AddWithValue("@IDEquip", manutencao.ID_Equipamento);
            cmd.Parameters.AddWithValue("@Data", manutencao.Data_Manutencao);
            cmd.Parameters.AddWithValue("@Desc", manutencao.Descricao);

            cmd.ExecuteNonQuery();
        }

        public List<Manutencao> Listar()
        {
            var lista = new List<Manutencao>();

            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"SELECT M.Registro_Manutencao, M.Data_Manutencao, M.Descricao, 
                                  M.ID_Funcionario, F.Nome as NomeFuncionario,
                                  M.ID_Equipamento, E.Nome_Equipamento as NomeEquipamento
                           FROM MANUTENCAO M
                           INNER JOIN FUNCIONARIOS F ON M.ID_Funcionario = F.ID_Funcionario
                           INNER JOIN EQUIPAMENTOS E ON M.ID_Equipamento = E.ID_Equipamento
                           ORDER BY M.Data_Manutencao DESC";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Manutencao
                {
                    Registro_Manutencao = (int)reader["Registro_Manutencao"],
                    Data_Manutencao = (DateTime)reader["Data_Manutencao"],
                    Descricao = reader["Descricao"].ToString(),
                    ID_Funcionario = (int)reader["ID_Funcionario"],
                    NomeFuncionario = reader["NomeFuncionario"].ToString(),
                    ID_Equipamento = (int)reader["ID_Equipamento"],
                    NomeEquipamento = reader["NomeEquipamento"].ToString()
                });
            }
            return lista;
        }

        public void Remover(int id)
        {
            using var conn = _connection.GetConnection();
            conn.Open();
            string sql = "DELETE FROM MANUTENCAO WHERE Registro_Manutencao = @ID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }
    }
}
