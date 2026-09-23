using MySql.Data.MySqlClient;
using System;

namespace GerenciadorVeiculos
{
    public static class ConexaoBD
    {
        private static string connectionString = "Server=localhost;Database=concessionaria_db;Uid=root;Pwd=;";

        public static MySqlConnection ObterConexao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar com o banco de dados MySQL: " + ex.Message);
            }
        }
    }
}