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
    public partial class FormMedicos : Form
    {
        public FormMedicos()
        {
            InitializeComponent();

            // A janela deverá surgir no centro da aplicação
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.Text = "Médicos";
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.MaximizeBox = false;
            this.MinimumSize = new Size(456, 455);
            this.SizeGripStyle = SizeGripStyle.Show;
            this.CancelButton = BotaoFechar;

            LabelFundo.Location = new Point(0, 0);
            LabelFundo.Width = this.ClientRectangle.Width;

            ListaMedicos.View = View.Details;
            ListaMedicos.FullRowSelect = true;
            // Acrescentar as colunas à lista de médicos
            ListaMedicos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ListaMedicos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ListaMedicos.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);

            // Popular a lista de médicos com dados
            PopularListaMedicos();

            this.ResumeLayout(false);
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
        /// Criar um novo médico.
        /// </summary>
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormMedico frmMedico = new FormMedico(TipoOperacao.Criar);

            // Mostrar a janela e verificar o resultado
            if (frmMedico.ShowDialog() == DialogResult.OK)
            {
                ResultadoOperacao resultado = Program.medicosClinica.Adicionar(frmMedico.DadosMedico);

                if (resultado.Tipo == TipoResultado.OK)
                {
                    // Obter o ID do novo médico
                    int id = Program.medicosClinica.IdUltimoRegistoInserido;

                    string nome = Program.medicosClinica.DadosMedicos[id].Nome;
                    string especialidade = Program.medicosClinica.DadosMedicos[id].EspecialidadeMedico.Designacao;

                    // Registar no  log
                    Log.AdicionarEvento(Log.TipoEvento.Info, $"Novo médico criado (ID: {id} - Nome: {nome} - Especialidade: {especialidade})");

                    MessageBox.Show("Novo médico criado com sucesso", "Criar Novo Médico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar lista de médicos
                    ListaMedicos.Items.Clear();
                    PopularListaMedicos();
                }
                
                // **** mostrar feedback caso haja erro
            }

            frmMedico.Dispose();
        }

        /// <summary>
        /// Editar os dados de um médico.
        /// </summary>
        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            // Verificar se o utilizador selecionou um médico da lista
            if (ListaMedicos.SelectedItems.Count > 0)
            {
                int id;

                // Obter o ID do médico selecionado
                if (int.TryParse(ListaMedicos.SelectedItems[0].SubItems[0].Text, out id))
                {
                    FormMedico frmMedico = new FormMedico(TipoOperacao.Editar);

                    frmMedico.DadosMedico = Program.medicosClinica.DadosMedicos[id];

                    // Mostrar a janela e verificar o resultado
                    if (frmMedico.ShowDialog() == DialogResult.OK)
                    {
                        ResultadoOperacao resultado = Program.medicosClinica.Atualizar(frmMedico.DadosMedico);

                        if (resultado.Tipo == TipoResultado.OK)
                        {
                            string nome = Program.medicosClinica.DadosMedicos[id].Nome;
                            string especialidade = Program.medicosClinica.DadosMedicos[id].EspecialidadeMedico.Designacao;

                            // Registar no  log
                            Log.AdicionarEvento(Log.TipoEvento.Info, $"Dados do médico atualizados (ID: {id} - Nome: {nome} - Especialidade: {especialidade})");

                            MessageBox.Show("Dados do médico atualizados com sucesso", "Editar Médico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar lista de médicos
                            ListaMedicos.Items.Clear();
                            PopularListaMedicos();
                        }

                        // **** mostrar feedback caso haja erro
                    }

                    frmMedico.Dispose();
                }                
            }
        }

        /// <summary>
        /// Eliminar o médico selecionado.
        /// </summary>
        private void BotaoEliminarMedico_Click(object sender, EventArgs e)
        {
            // Verificar que o utilizador selecioniou um médico
            if (ListaMedicos.SelectedItems.Count > 0)
            {
                int id;

                if (int.TryParse(ListaMedicos.SelectedItems[0].SubItems[0].Text, out id))
                {
                    string nome = Program.medicosClinica.DadosMedicos[id].Nome;
                    string especialidade = Program.medicosClinica.DadosMedicos[id].EspecialidadeMedico.Designacao;

                    // Confirmar esta operação
                    if (MessageBox.Show($"Confirma a remoção do médico selecionado?\n\nMédico: {nome}\nEspecialidade: {especialidade}", "Eliminar Médico", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        // **** testar se o médico tem marcações

                        ResultadoOperacao resultado = Program.medicosClinica.Eliminar(id);

                        if (resultado.Tipo == TipoResultado.OK)
                        {
                            // Registar no  log
                            Log.AdicionarEvento(Log.TipoEvento.Info, $"Médico eliminado (Nome: {nome} - Especialidade: {especialidade})");

                            MessageBox.Show("Registo eliminado com sucesso", "Eliminar Médico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar a lista de médicos
                            ListaMedicos.Items.Clear();
                            PopularListaMedicos();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fechar a janela.
        /// </summary>
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
