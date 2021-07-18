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
    public partial class FormPaciente : Form
    {
        public TipoOperacao Operacao { get; set; }

        public Paciente DadosPaciente { get; set; }

        public FormPaciente(TipoOperacao operacao)
        {
            InitializeComponent();

            Operacao = operacao;

            // A janela deverá surgir no centro da aplicação
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            if (Operacao == TipoOperacao.Criar)
            {
                this.Text = "Criar Novo Paciente";
                LabelMensagem.Text = "Insira os dados do novo paciente";
                LabelID.Text = "(por atribuir)";
            }
            else if (Operacao == TipoOperacao.Editar)
            {
                this.Text = "Editar Paciente";
                LabelMensagem.Text = "Edite os dados do paciente";
                LabelID.Text = DadosPaciente.Id.ToString();
            }

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.AcceptButton = BotaoOK;
            this.CancelButton = BotaoCancelar;
            
            ListaSistemasSaude.DropDownStyle = ComboBoxStyle.DropDownList;
            // Colocar dados na lista de sistemas de saúde
            foreach (SistemaSaude sistema in SistemasSaude.Dados.Values)
            {
                ListaSistemasSaude.Items.Add(sistema);
            }
            ListaSistemasSaude.DisplayMember = "Designacao";

            // Limitar o número de caracteres que podem ser inseridos
            Nome.MaxLength = 255;
            Email.MaxLength = 255;
            Morada.MaxLength = 255;
            Nif.MaxLength = 9;
            Telefone.MaxLength = 9;
            NumeroSistemaSaude.MaxLength = 30;

            // Configurar o controlo que aceita o código postal
            CodigoPostal.Mask = "0000-999";

            // Popular os controlos com dados caso a operação seja de edição
            if (Operacao == TipoOperacao.Editar)
            {
                PopularControlos();
            }

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Popular os controlos da form com os dados do paciente.
        /// </summary>
        private void PopularControlos()
        {
            Nome.Text = DadosPaciente.Nome;
            Telefone.Text = DadosPaciente.Telefone;
            Email.Text = DadosPaciente.Email;
            Morada.Text = DadosPaciente.Morada;
            CodigoPostal.Text = DadosPaciente.CodigoPostal;
            Nif.Text = DadosPaciente.Nif;
            ListaSistemasSaude.SelectedItem = DadosPaciente.SistemaSaudePaciente;
            NumeroSistemaSaude.Text = DadosPaciente.NumeroSistemaSaude;
            DataNascimento.Value = DadosPaciente.DataNascimento;
        }

        /// <summary>
        /// Terminar a operação.
        /// </summary>
        private void BotaoOK_Click(object sender, EventArgs e)
        {
            string caption = (Operacao == TipoOperacao.Criar) ? "Criar novo paciente" : "Editar paciente";

            // Verificar se todos os dados estão preenchidos
            if (String.IsNullOrEmpty(Nome.Text))
            {
                MessageBox.Show("Preencha todos os dados.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se o código postal foi corretamente preenchido
            if (CodigoPostal.Text != "    -")
            {
                if (!CodigoPostal.MaskCompleted)
                {
                    MessageBox.Show("Preencha o código postal corretamente.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (Operacao == TipoOperacao.Criar)
            {
                DadosPaciente = new Paciente(Nome.Text);
            }
            else if (Operacao == TipoOperacao.Editar)
            {
                DadosPaciente.Nome = Nome.Text;
            }

            DadosPaciente.Email = Email.Text;
            DadosPaciente.Morada = Morada.Text;

            // Verificar se o utilizador inseriu os últimos 3 algarismos do código postal
            if (CodigoPostal.Text.Length == 5 && CodigoPostal.Text[4] == '-')
            {
                // Não armazenar o caracter '-'
                DadosPaciente.CodigoPostal = CodigoPostal.Text.Substring(0, 4);
            }
            else
            {
                DadosPaciente.CodigoPostal = CodigoPostal.Text;
            }
            
            DadosPaciente.DataNascimento = DataNascimento.Value;
            DadosPaciente.Nif = Nif.Text;
            DadosPaciente.Telefone = Telefone.Text;

            if (ListaSistemasSaude.SelectedItem != null)
            {
                DadosPaciente.SistemaSaudePaciente = (SistemaSaude)ListaSistemasSaude.SelectedItem;
            }

            DadosPaciente.NumeroSistemaSaude = NumeroSistemaSaude.Text;

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
