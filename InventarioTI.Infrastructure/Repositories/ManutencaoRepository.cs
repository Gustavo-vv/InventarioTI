using InventarioTI.Domain.Entities;
using InventarioTI.Domain.Interfaces;
using InventarioTI.Infrastructure.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace InventarioTI.Infrastructure.Repositories
{
    public class ManutencaoRepository : IManutencaoRepository
    {
        private readonly DbConnection _connection = new DbConnection();

        public void Adicionar(Manutencao manutencao)
        {
            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO dbo.MANUTENCAO 
            (ID_Funcionario, ID_Equipamento, Data_Manutencao, Descricao) 
            VALUES (@Funcionario, @Equipamento, @Data, @Descricao)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Funcionario", manutencao.ID_Funcionario > 0 ? manutencao.ID_Funcionario : 2); // Exemplo de funcionário default 2, como no EquipamentoRepository
            cmd.Parameters.AddWithValue("@Equipamento", manutencao.ID_Equipamento);
            cmd.Parameters.AddWithValue("@Data", manutencao.Data_Manutencao);
            cmd.Parameters.AddWithValue("@Descricao", manutencao.Descricao);

            cmd.ExecuteNonQuery();
        }

        public List<Manutencao> Listar()
        {
            var lista = new List<Manutencao>();

            using var conn = _connection.GetConnection();
            conn.Open();

            string sql = @"
                SELECT 
                    M.Registro_Manutencao, M.ID_Funcionario, M.ID_Equipamento, 
                    M.Data_Manutencao, M.Descricao,
                    F.Nome AS NomeFuncionario,
                    E.Nome_Equipamento AS NomeEquipamento
                FROM dbo.MANUTENCAO M
                INNER JOIN dbo.FUNCIONARIOS F ON M.ID_Funcionario = F.ID_Funcionario
                INNER JOIN dbo.EQUIPAMENTOS E ON M.ID_Equipamento = E.ID_Equipamento";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Manutencao
                {
                    Registro_Manutencao = (int)reader["Registro_Manutencao"],
                    ID_Funcionario = reader["ID_Funcionario"] != DBNull.Value ? (int)reader["ID_Funcionario"] : 0,
                    ID_Equipamento = reader["ID_Equipamento"] != DBNull.Value ? (int)reader["ID_Equipamento"] : 0,
                    Data_Manutencao = reader["Data_Manutencao"] != DBNull.Value ? (DateTime)reader["Data_Manutencao"] : DateTime.MinValue,
                    Descricao = reader["Descricao"].ToString(),
                    NomeFuncionario = reader["NomeFuncionario"] != DBNull.Value ? reader["NomeFuncionario"].ToString() : "N/D",
                    NomeEquipamento = reader["NomeEquipamento"] != DBNull.Value ? reader["NomeEquipamento"].ToString() : "N/D"
                });
            }
            conn.Close();
            return lista;
        }

    
    }
}
