// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica_coimbra
{
    public static class Especialidades
    {
        /// <summary>
        /// Dados das especialidades.
        /// </summary>
        public static Dictionary<int, Especialidade> Dados { get; }  = new Dictionary<int, Especialidade>();

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

                    using (var command = new MySqlCommand("SELECT * FROM especialidades", connection))
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
                                    Especialidade especialidade = new Especialidade();

                                    // Nota Importante:
                                    //   Utilizar o método IsDBNull() para verificar se cada campo contém
                                    //   um valor NULL.
                                    //   Apenas ler o valor do campo se NÃO contiver o valor NULL.

                                    if (!reader.IsDBNull(0))
                                    {
                                        especialidade.Id = reader.GetInt32(0);
                                    }

                                    if (!reader.IsDBNull(1))
                                    {
                                        especialidade.Designacao = reader.GetString(1);
                                    }

                                    Dados.Add(especialidade.Id, especialidade);

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
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Especialidades.InicializarDados(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }
    }
}
