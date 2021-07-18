using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_coimbra
{
    static class Program
    {
        public static Medicos medicosClinica = new Medicos();
        public static Pacientes pacientesClinica = new Pacientes();
        public static Marcacoes marcacoesClinica = new Marcacoes();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Registar no log que o utilizador abriu a aplicação
            Log.AdicionarEvento(Log.TipoEvento.Info, "Acesso à aplicação");

            // Efetuar autenticação
            // *****
            //Application.Run(new FormAutenticacao());

            // Inicializar a aplicação
            Inicializar();

            //Application.Run(new FormMedicos());
            //Application.Run(new FormPacientes());

            Application.Run(new FormPrincipal());

            //Application.Run(new FormMarcacao());
        }

        private static void Inicializar()
        {
            ResultadoOperacao resultado;

            // Inicializar as especialidades
            resultado = Especialidades.InicializarDados();
            if (resultado.Tipo != TipoResultado.OK)
            {
                string msg = "Ocorreu um erro ao inicializar o programa";

                // Verificar se a base de dados está indisponível
                if (resultado.Tipo == TipoResultado.ErroBaseDadosLigacaoServidor)
                {
                    msg += ": não é possível efetuar a ligação à base de dados";
                }

                msg += ".\n\nPor favor tente novamente.";

                MessageBox.Show(msg, "Clínica Médica de Coimbra", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Environment.Exit(1);
            }

            // Inicializar os sistemas de saúde
            resultado = SistemasSaude.InicializarDados();
            if (resultado.Tipo != TipoResultado.OK)
            {
                string msg = "Ocorreu um erro ao inicializar o programa";

                // Verificar se a base de dados está indisponível
                if (resultado.Tipo == TipoResultado.ErroBaseDadosLigacaoServidor)
                {
                    msg += ": não é possível efetuar a ligação à base de dados";
                }

                msg += ".\n\nPor favor tente novamente.";

                MessageBox.Show(msg, "Clínica Médica de Coimbra", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Environment.Exit(1);
            }

            // Obter dados dos médicos
            resultado = medicosClinica.InicializarDados();
            if (resultado.Tipo != TipoResultado.OK)
            {
                MessageBox.Show("Ocorreu um erro ao inicializar o programa.\nPor favor tente novamente.", "Clínica Médica de Coimbra", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Environment.Exit(1);
            }

            // Obter dados dos pacientes
            resultado = pacientesClinica.InicializarDados();
            if (resultado.Tipo != TipoResultado.OK)
            {
                MessageBox.Show("Ocorreu um erro ao inicializar o programa.\nPor favor tente novamente.", "Clínica Médica de Coimbra", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Environment.Exit(1);
            }

            // Obter dados das marcações
            resultado = marcacoesClinica.InicializarDados();
            if (resultado.Tipo != TipoResultado.OK)
            {
                MessageBox.Show("Ocorreu um erro ao inicializar o programa.\nPor favor tente novamente.", "Clínica Médica de Coimbra", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Environment.Exit(1);
            }
        }
    }
}
