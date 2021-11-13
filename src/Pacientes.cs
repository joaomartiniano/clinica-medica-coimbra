// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica_coimbra
{
    class Pacientes
    {
        /// <summary>
        /// Dados dos pacientes.
        /// </summary>
        public Dictionary<int, Paciente> Dados { get; } = new Dictionary<int, Paciente>();

        /// <summary>
        /// Chave primária do último registo inserido.
        /// </summary>
        public int IdUltimoRegistoInserido { get; private set; } = 0;

        public Pacientes()
        { }

        /// <summary>
        /// Obter os dados dos pacientes a partir da base de dados.
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

                    using (var command = new MySqlCommand("SELECT * FROM pacientes", connection))
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
                                    Paciente paciente = new Paciente();

                                    // Nota Importante:
                                    //   Utilizar o método IsDBNull() para verificar se cada campo contém
                                    //   um valor NULL.
                                    //   Apenas ler o valor do campo se NÃO contiver o valor NULL.

                                    if (!reader.IsDBNull(0))
                                    {
                                        paciente.Id = reader.GetInt32(0);
                                    }

                                    if (!reader.IsDBNull(1))
                                    {
                                        paciente.Nome = reader.GetString(1);
                                    }

                                    if (!reader.IsDBNull(2))
                                    {
                                        paciente.Email = reader.GetString(2);
                                    }

                                    // Atenção: a password não é lida

                                    if (!reader.IsDBNull(4))
                                    {
                                        paciente.Morada = reader.GetString(4);
                                    }

                                    if (!reader.IsDBNull(5))
                                    {
                                        paciente.CodigoPostal = reader.GetString(5);
                                    }

                                    if (!reader.IsDBNull(6))
                                    {
                                        paciente.DataNascimento = (DateTime)reader.GetDateTime(6);
                                    }

                                    if (!reader.IsDBNull(7))
                                    {
                                        paciente.Nif = reader.GetString(7);
                                    }

                                    if (!reader.IsDBNull(8))
                                    {
                                        paciente.Telefone = reader.GetString(8);
                                    }

                                    // Sistema de saúde
                                    if (!reader.IsDBNull(9))
                                    {
                                        int sistemaSaudeId = reader.GetInt32(9);
                                        paciente.SistemaSaudePaciente = SistemasSaude.Dados[sistemaSaudeId];
                                    }

                                    if (!reader.IsDBNull(10))
                                    {
                                        paciente.NumeroSistemaSaude = reader.GetString(10);
                                    }

                                    Dados.Add(paciente.Id, paciente);

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
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Pacientes.InicializarDados(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }

        /// <summary>
        /// Adicionar um novo paciente, na base de dados e na lista de pacientes em memória.
        /// </summary>
        /// <param name="paciente">Dados do novo paciente.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao Adicionar(Paciente paciente)
        {
            ResultadoOperacao resultado = new ResultadoOperacao();
            long id = 0;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("INSERT INTO pacientes(Nome, Email, Morada, CodigoPostal, DataNascimento, NIF, Telefone, SistemaSaude_ID, NumeroSistemaSaude) VALUES (@nome, @email, @morada, @codigoPostal, @dataNascimento, @nif, @telefone, @sistemaSaude_ID, @numeroSistemaSaude)", connection))
                    {
                        command.Parameters.AddWithValue("@nome", paciente.Nome);
                        command.Parameters.AddWithValue("@email", paciente.Email);
                        command.Parameters.AddWithValue("@morada", paciente.Morada);
                        command.Parameters.AddWithValue("@codigoPostal", paciente.CodigoPostal);
                        command.Parameters.AddWithValue("@dataNascimento", paciente.DataNascimento);
                        command.Parameters.AddWithValue("@nif", paciente.Nif);
                        command.Parameters.AddWithValue("@telefone", paciente.Telefone);

                        if (paciente.SistemaSaudePaciente != null)
                        {
                            command.Parameters.AddWithValue("@sistemaSaude_ID", paciente.SistemaSaudePaciente.Id);
                        }
                        
                        command.Parameters.AddWithValue("@numeroSistemaSaude", paciente.NumeroSistemaSaude);

                        command.ExecuteNonQuery();

                        // Obter a chave primária do último registo inserido na base de dados
                        id = command.LastInsertedId;
                    }
                }

                // Armazenar a chave primário do novo registo, na propriedade adequada (desta classe)
                IdUltimoRegistoInserido = (int)id;

                paciente.Id = IdUltimoRegistoInserido;

                // Armazenar os dados do novo paciente na estrutura de dados desta classe
                Dados.Add((int)id, paciente);

                resultado.Tipo = TipoResultado.OK;
            }
            catch (MySqlException e)
            {
                resultado.Tipo = ResultadoOperacao.MapearExcecaoMySQLConnector(e.Number);
                resultado.Detalhe = e.Message;

                // Registar no log
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Pacientes.Adicionar(): Erro base de dados (Detalhes: {e.Message})");

                IdUltimoRegistoInserido = 0;
            }

            return resultado;
        }

        /// <summary>
        /// Eliminar um paciente, na base de dados e na lista de pacientes em memória.
        /// </summary>
        /// <param name="id">Chave primária do paciente a eliminar.</param>
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

                    using (var command = new MySqlCommand("DELETE FROM pacientes WHERE ID = @id", connection))
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
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Pacientes.Eliminar(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }

        /// <summary>
        /// Atualizar os dados de um paciente, na base de dados e na lista de pacientes em memória.
        /// </summary>
        /// <param name="paciente">Dados do paciente.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>
        public ResultadoOperacao Atualizar(Paciente paciente)
        {
            ResultadoOperacao resultado = new ResultadoOperacao();
            int i = 0;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("UPDATE pacientes SET Nome = @nome, Email = @email, Morada = @morada, CodigoPostal = @codigoPostal, DataNascimento = @dataNascimento, NIF = @nif, Telefone = @telefone, SistemaSaude_ID = @sistemaSaude_ID, NumeroSistemaSaude = @numeroSistemaSaude WHERE ID = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", paciente.Id);
                        command.Parameters.AddWithValue("@nome", paciente.Nome);
                        command.Parameters.AddWithValue("@email", paciente.Email);
                        command.Parameters.AddWithValue("@morada", paciente.Morada);
                        command.Parameters.AddWithValue("@codigoPostal", paciente.CodigoPostal);
                        command.Parameters.AddWithValue("@dataNascimento", paciente.DataNascimento);
                        command.Parameters.AddWithValue("@nif", paciente.Nif);
                        command.Parameters.AddWithValue("@telefone", paciente.Telefone);
                        command.Parameters.AddWithValue("@sistemaSaude_ID", paciente.SistemaSaudePaciente.Id);
                        command.Parameters.AddWithValue("@numeroSistemaSaude", paciente.NumeroSistemaSaude);

                        i = command.ExecuteNonQuery();
                    }
                }

                // Verificar se apenas foi afetado um registo
                if (i == 1)
                {
                    Dados[paciente.Id] = paciente;

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
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Pacientes.Atualizar(): Erro base de dados (Detalhes: {e.Message})");
            }

            return resultado;
        }
    }
}
