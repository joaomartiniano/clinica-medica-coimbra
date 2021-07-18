using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica_coimbra
{
    /// <summary>
    /// Esta classe trata da autenticação de um utilizador na aplicação.
    /// </summary>
    static class Autenticacao
    {
        public enum ResultadoAutenticacao
        {
            Nulo,

            /// <summary>Autenticação efetuada com sucesso.</summary>
            AutenticacaoValida,

            /// <summary>Autenticação falhou: username e/ou password inválido.</summary>
            AutenticacaoInvalida,

            /// <summary>Erro de acesso à base de dados.</summary>
            ErroBaseDados
        }

        /// <summary>
        /// Tamanho máximo (em caracteres) do username.
        /// </summary>
        public const int UsernameMaxLength = 20;

        /// <summary>
        /// Tamanho máximo (em caracteres) da password.
        /// </summary>
        public const int PasswordMaxLength = 255;

        /// <summary>
        /// Efetua a autenticação (login) de um utilizador.
        /// </summary>
        /// <param name="username">Username do utilizador.</param>
        /// <param name="password">Password do utilizador.</param>
        /// <returns>Um valor da enumeração ResultadoAutenticacao.</returns>
        public static ResultadoAutenticacao Autenticar(string username, string password)
        {
            ResultadoAutenticacao estadoAutenticacao = ResultadoAutenticacao.AutenticacaoInvalida;

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("SELECT 1 FROM Utilizadores WHERE Username = @username AND Password = @password", connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Executar o comando SQL
                        // (o valor devolvidos pelo método ExecuteScalar() é colocado na variável resultado)
                        object resultado = command.ExecuteScalar();

                        if (resultado != null)
                        {
                            // Verificar se resultado contém o valor inteiro 1
                            if (Convert.ToInt32(resultado) == 1)
                            {
                                // Autenticação bem sucedida
                                estadoAutenticacao = ResultadoAutenticacao.AutenticacaoValida;
                            }
                        }
                    }

                    if (estadoAutenticacao != ResultadoAutenticacao.AutenticacaoValida)
                    {
                        // Registar no log que ocorreu uma autenticação inválida
                        Log.AdicionarEvento(Log.TipoEvento.Aviso, "Autenticação inválida");
                    }
                }
            }
            catch (MySqlException e)
            {
                estadoAutenticacao = ResultadoAutenticacao.ErroBaseDados;

                // Registar no log que ocorreu uma autenticação inválida
                Log.AdicionarEvento(Log.TipoEvento.Erro, $"Autenticacao.Autenticar(): Erro base de dados (Detalhes: {e.Message})");
            }

            return estadoAutenticacao;
        }
    }
}
