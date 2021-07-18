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
    public partial class FormMarcacao : Form
    {
        public Marcacao DadosMarcacao { get; private set; }

        public FormMarcacao()
        {
            InitializeComponent();

            // A janela deverá surgir no centro da aplicação
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormMarcacao_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.Text = "Nova Marcação";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            LabelFundo.Location = new Point(0, 0);
            LabelFundo.Width = this.ClientRectangle.Width;

            ListaPacientes.View = View.Details;
            ListaPacientes.FullRowSelect = true;
            // Acrescentar as colunas à lista de pacientes
            ListaPacientes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("Telefone", 80, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("NIF", 80, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("Sistema Saúde", -2, HorizontalAlignment.Left);

            ListaMedicos.View = View.Details;
            ListaMedicos.FullRowSelect = true;
            // Acrescentar as colunas à lista de médicos
            ListaMedicos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ListaMedicos.Columns.Add("Nome", 130, HorizontalAlignment.Left);
            ListaMedicos.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);

            // Popular a lista de pacientes com dados
            PopularListaPacientes();

            // Popular a lista de médicos com dados
            PopularListaMedicos();

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Inserir na lista de pacientes, todos os pacientes armazenados no sistema.
        /// </summary>
        private void PopularListaPacientes()
        {
            foreach (Paciente p in Program.pacientesClinica.DadosPacientes.Values)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Nome, p.Telefone, p.Nif, p.SistemaSaudePaciente.Designacao });
                ListaPacientes.Items.Add(item);
            }
        }

        /// <summary>
        /// Inserir na lista de médicos, todos os médicos armazenados no sistema.
        /// </summary>
        private void PopularListaMedicos()
        {
            foreach (Medico m in Program.medicosClinica.DadosMedicos.Values)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Id.ToString(), m.Nome, m.EspecialidadeMedico.Designacao });
                ListaMedicos.Items.Add(item);
            }
        }

        /// <summary>
        /// Confirmar a marcação.
        /// </summary>
        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            if ((ListaPacientes.SelectedItems.Count == 0) || (ListaMedicos.SelectedItems.Count == 0))
            {
                MessageBox.Show("Marcação incompleta: selecione paciente e médico.", "Marcação de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPaciente, idMedico;

            // Obter o id do paciente e do médico
            if (int.TryParse(ListaPacientes.SelectedItems[0].SubItems[0].Text, out idPaciente))
            {
                if (int.TryParse(ListaMedicos.SelectedItems[0].SubItems[0].Text, out idMedico))
                {
                    DadosMarcacao = new Marcacao();
                    DadosMarcacao.PacienteMarcacao = Program.pacientesClinica.DadosPacientes[idPaciente];
                    DadosMarcacao.MedicoMarcacao = Program.medicosClinica.DadosMedicos[idMedico];
                    DadosMarcacao.DataHora = new DateTime(Data.Value.Year, Data.Value.Month, Data.Value.Day, Hora.Value.Hour, Hora.Value.Minute, Hora.Value.Second);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Fechar a janela.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
