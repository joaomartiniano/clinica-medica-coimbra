// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica_coimbra
{
    class Marcacoes
    {
        /// <summary>
        /// Dados das marcações.
        /// </summary>
        public Dictionary<int, Marcacao> Dados { get; } = new Dictionary<int, Marcacao>();

        /// <summary>
        /// Chave primária do último registo inserido.
        /// </summary>
        public int IdUltimoRegistoInserido { get; private set; } = 0;

        public Marcacoes()
        { }

        /// <summary>
        /// Obter os dados das marcações, a partir da base de dados.
        /// </summary>
        public ResultadoOperacao InicializarDados()
        {
            ResultadoOperacao resultado = new ResultadoOperacao();

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("SELECT * FROM marcacoes", connection))
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
                                    Marcacao marcacao = new Marcacao();

                                    // Nota Importante:
                                    //   Utilizar o método IsDBNull() para verificar se cada campo contém
                                    //   um valor NULL.
                                    //   Apenas ler o valor do campo se NÃO contiver o valor NULL.

                                    if (!reader.IsDBNull(0))
                                    {
                                        marcacao.Id = reader.GetInt32(0);
                                    }

                                    if (!reader.IsDBNull(1))
                                    {
                                        // Paciente
                                        int pacienteId = reader.GetInt32(1);
                                        marcacao.PacienteMarcacao = Program.PacientesClinica.Dados[pacienteId];
                                    }

                                    if (!reader.IsDBNull(2))
                                    {
                                        // Médico
                                        int medicoId = reader.GetInt32(2);
                                        marcacao.MedicoMarcacao= Program.MedicosClinica.Dados[medicoId];
                                    }

                                    if (!reader.IsDBNull(3))
                                    {
                                        marcacao.DataHora = (DateTime)reader.GetDateTime(3);
                                    }

                                    Dados.Add(marcacao.Id, marcacao);

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
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Marcacoes.InicializarDados(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }

        /// <summary>
        /// Adicionar uma nova marcação, na base de dados e na lista de marcações em memória.
        /// </summary>
        /// <param name="marcacao">Dados da nova marcação.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao Adicionar(Marcacao marcacao)
        {
            ResultadoOperacao resultado = new ResultadoOperacao();
            long id = 0;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("INSERT INTO marcacoes(Paciente_ID, Medico_ID, DataHora) VALUES (@paciente_ID, @medico_ID, @dataHora)", connection))
                    {
                        command.Parameters.AddWithValue("@paciente_ID", marcacao.PacienteMarcacao.Id);
                        command.Parameters.AddWithValue("@medico_ID", marcacao.MedicoMarcacao.Id);
                        command.Parameters.AddWithValue("@dataHora", marcacao.DataHora);

                        command.ExecuteNonQuery();

                        // Obter a chave primária do último registo inserido na base de dados
                        id = command.LastInsertedId;
                    }
                }

                // Armazenar a chave primário do novo registo, na propriedade adequada (desta classe)
                IdUltimoRegistoInserido = (int)id;

                marcacao.Id = IdUltimoRegistoInserido;

                // Armazenar os dados da nova marcação na estrutura de dados desta classe
                Dados.Add((int)id, marcacao);

                resultado.Tipo = TipoResultado.OK;
            }
            catch (MySqlException e)
            {
                resultado.Tipo = ResultadoOperacao.MapearExcecaoMySQLConnector(e.Number);
                resultado.Detalhe = e.Message;

                // Registar no log
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Marcacoes.Adicionar(): Erro base de dados (Detalhes: {e.Message})");

                IdUltimoRegistoInserido = 0;
            }

            return resultado;
        }
    }
}
