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
    public partial class FormMedico : Form
    {
        public TipoOperacao Operacao { get; set; }

        public Medico DadosMedico { get; set; }

        public FormMedico(TipoOperacao operacao)
        {
            InitializeComponent();

            Operacao = operacao;

            // A janela deverá surgir no centro da aplicação
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormMedico_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            if (Operacao == TipoOperacao.Criar)
            {
                this.Text = "Criar Novo Médico";
                LabelMensagem.Text = "Insira os dados do novo médico";
                LabelID.Text = "(por atribuir)";
            }
            else if (Operacao == TipoOperacao.Editar)
            {
                this.Text = "Editar Médico";
                LabelMensagem.Text = "Edite os dados do médico";
                LabelID.Text = DadosMedico.Id.ToString();
            }

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.AcceptButton = BotaoOK;
            this.CancelButton = BotaoCancelar;

            ListaEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            // Colocar dados na lista de especialidades
            foreach (Especialidade especialidade in Especialidades.Dados.Values)
            {
                ListaEspecialidades.Items.Add(especialidade);
            }
            ListaEspecialidades.DisplayMember = "Designacao";

            // Limitar o número de caracteres que podem ser inseridos
            Nome.MaxLength = 255;

            // Popular os controlos com dados caso a operação seja de edição
            if (Operacao == TipoOperacao.Editar)
            {
                Nome.Text = DadosMedico.Nome;
                ListaEspecialidades.SelectedItem = DadosMedico.EspecialidadeMedico;
            }

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Terminar a operação.
        /// </summary>
        private void BotaoOK_Click(object sender, EventArgs e)
        {
            // Verificar se todos os dados estão preenchidos
            if (String.IsNullOrEmpty(Nome.Text) || (ListaEspecialidades.SelectedItem == null))
            {
                string caption = (Operacao == TipoOperacao.Criar) ? "Criar novo médico" : "Editar médico";
                MessageBox.Show("Preencha todos os dados.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Operacao == TipoOperacao.Criar)
            {
                DadosMedico = new Medico(0, Nome.Text, ((Especialidade)ListaEspecialidades.SelectedItem));
            }
            else if (Operacao == TipoOperacao.Editar)
            {
                DadosMedico.Nome = Nome.Text;
                DadosMedico.EspecialidadeMedico = ((Especialidade)ListaEspecialidades.SelectedItem);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancelar a operação e fechar a janela.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
