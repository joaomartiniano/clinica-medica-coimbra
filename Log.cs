using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace clinica_coimbra
{
    /// <summary>
    /// Esta classe adiciona registos ao log da aplicação.
    /// </summary>
    static class Log
    {
        /// <summary>
        /// O tipo do evento a registar.
        /// </summary>
        public enum TipoEvento
        {
            Nulo,
            Info,
            Aviso,
            Erro            
        }

        /// <summary>
        /// Localização e nome do ficheiro de log.
        /// </summary>
        private const string FicheiroLog = @"clinica-medica.log";

        /// <summary>
        /// Adicionar um evento ao log.
        /// </summary>
        /// <param name="tipo">Tipo de evento a registar.</param>
        /// <param name="mensagem">Mensagem explicativa do evento.</param>
        public static void AdicionarEvento(TipoEvento tipo, string mensagem)
        {
            string msg = $"{DateTime.Now} [{tipo.ToString().ToUpper()}] {mensagem}";

            // Verificar se o ficheiro já existe
            if (!File.Exists(FicheiroLog))
            {
                // Criar o ficheiro
                using (StreamWriter ficheiro = File.CreateText(FicheiroLog))
                {
                    ficheiro.WriteLine(msg);
                }
            }
            else
            {
                // O ficheiro de log já existe: adicionar o evento ao ficheiro
                using (StreamWriter ficheiro = File.AppendText(FicheiroLog))
                {
                    ficheiro.WriteLine(msg);
                }
            }
        }
    }
}
