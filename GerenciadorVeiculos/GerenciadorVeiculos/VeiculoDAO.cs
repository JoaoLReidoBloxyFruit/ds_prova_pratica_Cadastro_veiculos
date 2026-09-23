using MySql.Data.MySqlClient;
using System;

namespace GerenciadorVeiculos
{
    public class VeiculoDAO
    {
        public void Inserir(Veiculo veiculo)
        {
            string tipo = "";
            decimal parametro = 0;

            if (veiculo is Carro carro)
            {
                tipo = "Carro";
                parametro = carro.QuantidadePortas;
            }
            else if (veiculo is Moto moto)
            {
                tipo = "Moto";
                parametro = moto.Cilindradas;
            }

            string sql = "INSERT INTO veiculos (modelo, tipo, preco_base, valor_seguro, parametro_especifico) " +
                         "VALUES (@modelo, @tipo, @preco_base, @valor_seguro, @parametro_especifico)";

            using (MySqlConnection conexao = ConexaoBD.ObterConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@preco_base", veiculo.PrecoBase);
                    comando.Parameters.AddWithValue("@valor_seguro", veiculo.CalcularValorSeguro());
                    comando.Parameters.AddWithValue("@parametro_especifico", parametro);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}