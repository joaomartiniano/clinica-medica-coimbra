// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica_coimbra
{
    public static class SistemasSaude
    {
        /// <summary>
        /// Dados dos sistemas de saúde.
        /// </summary>
        public static Dictionary<int, SistemaSaude> Dados { get; } = new Dictionary<int, SistemaSaude>();

        /// <summary>
        /// Obter os dados das especialidades, a partir da base de dados.
        /// </summary>
        public static ResultadoOperacao InicializarDados()
        {
            ResultadoOperacao resultado = new ResultadoOperacao();

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("SELECT * FROM sistemas_saude", connection))
                    {
                        // Executar o comando SQL
                        // (os dados devolvidos pelo comando são colocados na variável reader)
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Determinar se foram devolvidos dados
                            if (reader.HasRows)
                            {
                                // Percorrer os registos obtidos a partir da base de dados
                                while (reader.Read())
                                {
                                    SistemaSaude sistemaSaude = new SistemaSaude();

                                    // Nota Importante:
                                    //   Utilizar o método IsDBNull() para verificar se cada campo contém
                                    //   um valor NULL.
                                    //   Apenas ler o valor do campo se NÃO contiver o valor NULL.

                                    if (!reader.IsDBNull(0))
                                    {
                                        sistemaSaude.Id = reader.GetInt32(0);
                                    }

                                    if (!reader.IsDBNull(1))
                                    {
                                        sistemaSaude.Designacao = reader.GetString(1);
                                    }

                                    Dados.Add(sistemaSaude.Id, sistemaSaude);

                                    resultado.Tipo = TipoResultado.OK;
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                resultado.Tipo = ResultadoOperacao.MapearExcecaoMySQLConnector(e.Number);
                resultado.Detalhe = e.Message;

                // Registar no log
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"SistemasSaude.InicializarDados(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }
    }
}
