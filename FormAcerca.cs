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
    public partial class FormAcerca : Form
    {
        public FormAcerca()
        {
            InitializeComponent();

            // A janela deverá surgir no centro da aplicação
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormAcerca_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.Text = "Acerca desta Aplicação";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;

            LabelFundo.Width = this.ClientSize.Width;

            //LinkComponenteMySQLConnector.

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Fechar a janela.
        /// </summary>
        private void BotaoOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abrir um browser quando o utilizador clica no link.
        /// </summary>
        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Link1.Text);
        }

        /// <summary>
        /// Abrir um browser quando o utilizador clica no link.
        /// </summary>
        private void Link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Link2.Text);
        }
    }
}
