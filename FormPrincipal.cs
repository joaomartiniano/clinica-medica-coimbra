using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace clinica_coimbra
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// **** temporário: abrir form médicos ****
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.Text = "Clínica Médica de Coimbra";
            //this.WindowState = FormWindowState.Maximized;

            // Coordenadas e dimensões dos controlos
            CalendarioMeses.Left = 0;
            CalendarioMeses.Top = toolStrip1.Top + toolStrip1.Height;
            CalendarioMeses.Height = this.ClientSize.Height - menuStrip1.Height - toolStrip1.Height;
            LabelFundo.Top = CalendarioMeses.Top;
            LabelFundo.Left = CalendarioMeses.Left + CalendarioMeses.Width;
            LabelFundo.Width = this.ClientSize.Width - CalendarioMeses.Width;
            Calendario.Top = LabelFundo.Top + LabelFundo.Height;
            Calendario.Left = LabelFundo.Left;
            Calendario.Width = this.ClientSize.Width - CalendarioMeses.Width;
            Calendario.Height = this.ClientSize.Height - menuStrip1.Height - toolStrip1.Height - LabelFundo.Height;

            // Calendário dos meses
            CalendarioMeses.SelectionMode = MonthView.MonthViewSelection.Day;

            // Experiência
            Calendario.ViewStart = new DateTime(2021, 07, 12);
            Calendario.ViewEnd = new DateTime(2021, 07, 17);
            DateTime d = new DateTime(2021, 07, 17);
            // (fim experiência)

            CalendarioMeses.DayNamesLength = 3;

            // Inserir itens no calendário
            //Calendario.items
            PlaceItemsCalendario();

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Aceder aos dados dos pacientes.
        /// </summary>
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPacientes frmPacientes = new FormPacientes();
            frmPacientes.ShowDialog();
            frmPacientes.Dispose();
        }

        /// <summary>
        /// Aceder aos dados dos médicos.
        /// </summary>
        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicos frmMedicos = new FormMedicos();
            frmMedicos.ShowDialog();
            frmMedicos.Dispose();
        }

        private void Calendario_LoadItems(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {
            PlaceItemsCalendario();
        }

        private void PlaceItemsCalendario()
        {
            Calendario.Items.Add(new CalendarItem(Calendario, new DateTime(2021, 07, 13, 09, 00, 00), new DateTime(2021, 07, 13, 10, 00, 00), "Anos Beatriz"));
        }

        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Criar uma nova marcação.
        /// </summary>
        private void BotaoNovaMarcacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!");

            

            /*FormMarcacao frmMarcacao = new FormMarcacao();
            
            if (frmMarcacao.ShowDialog() == DialogResult.OK)
            {
                ResultadoOperacao resultado = Program.marcacoesClinica.Adicionar(frmMarcacao.DadosMarcacao);

                if (resultado.Tipo == TipoResultado.OK)
                {
                    // Obter o ID da nova marcação
                    int id = Program.marcacoesClinica.IdUltimoRegistoInserido;

                    string nomePaciente = Program.marcacoesClinica.Dados[id].PacienteMarcacao.Nome;
                    string nomeMedico = Program.marcacoesClinica.Dados[id].MedicoMarcacao.Nome;
                    DateTime dataHora = Program.marcacoesClinica.Dados[id].DataHora;

                    // Registar no  log
                    Log.AdicionarEvento(Log.TipoEvento.Info, $"Nova marcação criada (ID: {id} - Data/Hora: {dataHora} - Paciente: {nomePaciente} - Médico: {nomeMedico})");

                    // ****
                    MessageBox.Show("Marcação criada com sucesso.", "Nova Marcação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar calendário
                    // ****
                }

                // **** mostrar feedback caso haja erro

            }

            frmMarcacao.Dispose();*/
        }

        /// <summary>
        /// Mostrar informações acerca desta aplicação.
        /// </summary>
        private void acercaDaAplicacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcerca frmAcerca = new FormAcerca();
            frmAcerca.ShowDialog();
            frmAcerca.Dispose();
        }

        /// <summary>
        /// Ocorre quando é selecionado um dia.
        /// </summary>
        private void CalendarioMeses_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("!");
            
        }
    }
}
