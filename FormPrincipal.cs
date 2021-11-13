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
using System.Windows.Forms.Calendar;

namespace clinica_coimbra
{
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Armazena os itens (ou seja, marcações) do calendário.
        /// </summary>
        private Dictionary<int, CalendarItem> ItensCalendario = new Dictionary<int, CalendarItem>();

        public FormPrincipal()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã e maximizada
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Inicializar os itens do calendário: percorrer as marcações
            foreach (Marcacao m in Program.MarcacoesClinica.Dados.Values)
            {
                ItensCalendario.Add(m.Id, new CalendarItem(Calendario, m.DataHora, m.DataHora.AddMinutes(50), $"Médico:{m.MedicoMarcacao.Nome}\nPaciente:{m.PacienteMarcacao.Nome}"));
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.Text = "Clínica Médica de Coimbra";

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

            // Calendário mensal: configuração
            CalendarioMeses.SelectionMode = MonthView.MonthViewSelection.Day;
            CalendarioMeses.DayNamesLength = 3;

            // Não permitir adicionar e editar itens diretamente no calendário
            Calendario.AllowNew = false;
            Calendario.AllowItemEdit = false;
            Calendario.AllowItemResize = false;
            // Colocar o calendário a mostrar marcações a partir das 08h00
            Calendario.TimeUnitsOffset = -16;

            // Colocar o calendário a mostrar a semana da data atual
            DateTime d = DateTime.Now;
            DateTime inicio = d.Subtract(TimeSpan.FromDays((double)d.DayOfWeek));
            DateTime fim = d.AddDays(DayOfWeek.Saturday - d.DayOfWeek);
            Calendario.SetViewRange(inicio, fim);

            // Inserir itens (marcações) no calendário
            PlaceItemsCalendario();

            this.ResumeLayout(false);
        }

        private void Calendario_LoadItems(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {
            PlaceItemsCalendario();
        }

        /// <summary>
        /// Adicionar itens ao calendário.
        /// </summary>
        private void PlaceItemsCalendario()
        {
            // Percorrer as marcações
            foreach (CalendarItem item in ItensCalendario.Values)
            {
                // Importante por razões de performance: apenas colocar no calendário, os itens que ocorrem na semana selecionada
                if (Calendario.ViewIntersects(item))
                {
                    Calendario.Items.Add(item);
                }
            }
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

        /// <summary>
        /// Criar uma nova marcação (opção de menu).
        /// </summary>
        private void novaMarcacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovaMarcacao();
        }

        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Criar uma nova marcação (botão da barra de ícones).
        /// </summary>
        private void BotaoNovaMarcacao_Click(object sender, EventArgs e)
        {
            CriarNovaMarcacao();
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
        /// Ocorre quando é selecionado um dia no calendário dos meses: o calendário mostra a semana da data selecionada.
        /// </summary>
        private void CalendarioMeses_SelectionChanged(object sender, EventArgs e)
        {
            DateTime d = CalendarioMeses.SelectionStart;
            DateTime inicio = d.Subtract(TimeSpan.FromDays((double)d.DayOfWeek));
            DateTime fim = d.AddDays(DayOfWeek.Saturday - d.DayOfWeek);
            Calendario.SetViewRange(inicio, fim);
        }

        /// <summary>
        /// Implementação da operação de criação de nova marcação.
        /// </summary>
        private void CriarNovaMarcacao()
        {
            FormMarcacao frmMarcacao = new FormMarcacao();

            if (frmMarcacao.ShowDialog() == DialogResult.OK)
            {
                ResultadoOperacao resultado = Program.MarcacoesClinica.Adicionar(frmMarcacao.DadosMarcacao);

                if (resultado.Tipo == TipoResultado.OK)
                {
                    // Obter o ID da nova marcação
                    int id = Program.MarcacoesClinica.IdUltimoRegistoInserido;

                    string nomePaciente = Program.MarcacoesClinica.Dados[id].PacienteMarcacao.Nome;
                    string nomeMedico = Program.MarcacoesClinica.Dados[id].MedicoMarcacao.Nome;
                    DateTime dataHora = Program.MarcacoesClinica.Dados[id].DataHora;

                    // Registar no  log
                    Log.AdicionarEvento(Log.TipoEvento.Info, $"Nova marcação criada (ID: {id} - Data/Hora: {dataHora} - Paciente: {nomePaciente} - Médico: {nomeMedico})");

                    MessageBox.Show("Marcação criada com sucesso.", "Nova Marcação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar calendário: inserir itens (marcações) no calendário
                    Marcacao m = Program.MarcacoesClinica.Dados[id];
                    ItensCalendario.Add(m.Id, new CalendarItem(Calendario, m.DataHora, m.DataHora.AddMinutes(50), $"Médico:{m.MedicoMarcacao.Nome}\nPaciente:{m.PacienteMarcacao.Nome}"));
                    PlaceItemsCalendario();
                }
                else
                {
                    // Mostrar feedback caso tenha ocorrido um erro
                    MessageBox.Show("Ocorreu um erro ao tentar inserir os dados da marcação", "Nova Marcação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            frmMarcacao.Dispose();
        }
    }
}
