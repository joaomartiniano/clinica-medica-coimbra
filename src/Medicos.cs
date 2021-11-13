// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica_coimbra
{
    class Medicos
    {
        /// <summary>
        /// Dados dos médicos.
        /// </summary>
        public Dictionary<int, Medico> Dados { get; } = new Dictionary<int, Medico>();

        /// <summary>
        /// Chave primária do último registo inserido.
        /// </summary>
        public int IdUltimoRegistoInserido { get; private set; } = 0;

        public Medicos()
        { }

        /// <summary>
        /// Obter os dados dos médicos a partir da base de dados.
        /// </summary>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao InicializarDados()
        {
            ResultadoOperacao resultado = new ResultadoOperacao();

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("SELECT * FROM medicos", connection))
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
                                    Medico medico = new Medico();

                                    // Nota Importante:
                                    //   Utilizar o método IsDBNull() para verificar se cada campo contém
                                    //   um valor NULL.
                                    //   Apenas ler o valor do campo se NÃO contiver o valor NULL.

                                    if (!reader.IsDBNull(0))
                                    {
                                        medico.Id = reader.GetInt32(0);
                                    }

                                    if (!reader.IsDBNull(1))
                                    {
                                        medico.Nome = reader.GetString(1);
                                    }

                                    // Especialidade
                                    if (!reader.IsDBNull(2))
                                    {
                                        int especialidadeId = reader.GetInt32(2);
                                        medico.EspecialidadeMedico = Especialidades.Dados[especialidadeId];
                                    }

                                    Dados.Add(medico.Id, medico);

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
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Medicos.InicializarDados(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }

        /// <summary>
        /// Adicionar um novo médico, na base de dados e na lista de médicos em memória.
        /// </summary>
        /// <param name="medico">Dados do novo médico.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao Adicionar(Medico medico)
        {
            ResultadoOperacao resultado = new ResultadoOperacao();
            long id = 0;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("INSERT INTO medicos(Nome, Especialidade_ID) VALUES (@nome, @especialidade_ID)", connection))
                    {
                        command.Parameters.AddWithValue("@nome", medico.Nome);
                        command.Parameters.AddWithValue("@especialidade_ID", medico.EspecialidadeMedico.Id);

                        command.ExecuteNonQuery();

                        // Obter a chave primária do último registo inserido na base de dados
                        id = command.LastInsertedId;
                    }
                }

                // Armazenar a chave primário do novo registo, na propriedade adequada (desta classe)
                IdUltimoRegistoInserido = (int)id;
                
                medico.Id = IdUltimoRegistoInserido;

                // Armazenar os dados do novo médico na estrutura de dados desta classe
                Dados.Add((int)id, medico);

                resultado.Tipo = TipoResultado.OK;                
            }
            catch (MySqlException e)
            {
                resultado.Tipo = ResultadoOperacao.MapearExcecaoMySQLConnector(e.Number);
                resultado.Detalhe = e.Message;

                // Registar no log
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Medicos.Adicionar(): Erro base de dados (Detalhes: {e.Message})");

                IdUltimoRegistoInserido = 0;
            }

            return resultado;
        }

        /// <summary>
        /// Eliminar um médico, na base de dados e na lista de médicos em memória.
        /// </summary>
        /// <param name="id">Chave primária do médico a eliminar.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao Eliminar(int id)
        {
            ResultadoOperacao resultado = new ResultadoOperacao();
            int i = 0;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("DELETE FROM medicos WHERE ID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        i = command.ExecuteNonQuery();
                    }
                }

                // Verificar se apenas foi afetado um registo
                if (i == 1)
                {
                    if (Dados.Remove(id))
                    {
                        resultado.Tipo = TipoResultado.OK;
                    }
                    else
                    {
                        resultado.Tipo = TipoResultado.Erro;
                    }                    
                }
                else
                {
                    resultado.Tipo = TipoResultado.Erro;
                }

                resultado.Tipo = TipoResultado.OK;
            }
            catch (MySqlException e)
            {
                resultado.Tipo = ResultadoOperacao.MapearExcecaoMySQLConnector(e.Number);
                resultado.Detalhe = e.Message;

                // Registar no log
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Medicos.Eliminar(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }

        /// <summary>
        /// Atualizar os dados de um médico, na base de dados e na lista de médicos em memória.
        /// </summary>
        /// <param name="medico">Dados do médico.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao Atualizar(Medico medico)
        {
            ResultadoOperacao resultado = new ResultadoOperacao();
            int i = 0;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("UPDATE medicos SET Nome = @nome, Especialidade_ID = @especialidade_id WHERE ID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", medico.Id);
                        command.Parameters.AddWithValue("@nome", medico.Nome);
                        command.Parameters.AddWithValue("@especialidade_id", medico.EspecialidadeMedico.Id);

                        i = command.ExecuteNonQuery();
                    }
                }

                // Verificar se apenas foi afetado um registo
                if (i == 1)
                {
                    Dados[medico.Id] = medico;

                    resultado.Tipo = TipoResultado.OK;
                }
                else
                {
                    resultado.Tipo = TipoResultado.Erro;
                }

                resultado.Tipo = TipoResultado.OK;
            }
            catch (MySqlException e)
            {
                resultado.Tipo = ResultadoOperacao.MapearExcecaoMySQLConnector(e.Number);
                resultado.Detalhe = e.Message;

                // Registar no log
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Medicos.Atualizar(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }
    }
}
