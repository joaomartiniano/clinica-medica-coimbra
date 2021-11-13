// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_coimbra
{
    public partial class FormAutenticacao : Form
    {
        public FormAutenticacao()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAutenticacao_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.AcceptButton = BotaoOk;
            this.CancelButton = BotaoCancelar;
            this.Text = "Autenticação";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            LabelFundo.Width = this.ClientSize.Width;
            LabelMensagemErro.Visible = false;
            Utilizador.MaxLength = Autenticacao.UsernameMaxLength;
            Password.MaxLength = Autenticacao.PasswordMaxLength;
            Password.UseSystemPasswordChar = true;

            BotaoOk.Enabled = false;

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Efetuar a autenticação.
        /// </summary>
        private void BotaoOk_Click(object sender, EventArgs e)
        {
            LabelMensagemErro.Text = "A autenticar...";
            LabelMensagemErro.ForeColor = Color.Black;
            LabelMensagemErro.Visible = true;

            if (!String.IsNullOrWhiteSpace(Utilizador.Text) && (!String.IsNullOrWhiteSpace(Password.Text)))
            {
                // Tentar a autenticação com os dados fornecidos pelo utilizador
                Autenticacao.ResultadoAutenticacao resultado = Autenticacao.Autenticar(Utilizador.Text, Password.Text);

                switch (resultado)
                {
                    case Autenticacao.ResultadoAutenticacao.AutenticacaoValida:
                        this.Close();
                        break;

                    case Autenticacao.ResultadoAutenticacao.AutenticacaoInvalida:
                        LabelMensagemErro.Text = "Autenticação inválida:\nusername e/ou password incorretos.";
                        LabelMensagemErro.ForeColor = Color.Red;
                        break;

                    case Autenticacao.ResultadoAutenticacao.ErroBaseDados:
                        MessageBox.Show("Ocorreu um erro no sistema que impediu a autenticação.\nPor favor contacte o administrador ou tente novamente.", "Erro de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LabelMensagemErro.Visible = false;

                        Utilizador.Text = string.Empty;
                        Password.Text = string.Empty;
                        break;
                }

                Utilizador.Focus();
            }
        }

        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Efetuar verificações sempre que o utilizador modifica o username.
        /// </summary>
        private void Utilizador_TextChanged(object sender, EventArgs e)
        {
            BotaoOk.Enabled = ExistemDadosAutenticacao();

            // Esconder mensagem de feedback antiga
            LabelMensagemErro.Visible = false;
        }

        /// <summary>
        /// Efetuar verificações sempre que o utilizador modifica a password.
        /// </summary>
        private void Password_TextChanged(object sender, EventArgs e)
        {
            BotaoOk.Enabled = ExistemDadosAutenticacao();

            // Esconder mensagem de feedback antiga
            LabelMensagemErro.Visible = false;
        }

        /// <summary>
        /// Verifica que os controlos de inserção de dados de autenticação contêm dados.
        /// </summary>
        /// <returns>True caso existam dados de autenticação, False caso contrário.</returns>
        private bool ExistemDadosAutenticacao()
        {
            if (String.IsNullOrWhiteSpace(Utilizador.Text) || (String.IsNullOrWhiteSpace(Password.Text)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
