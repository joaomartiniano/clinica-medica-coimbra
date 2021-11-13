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
            foreach (Medico m in Program.MedicosClinica.Dados.Values)
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
                ResultadoOperacao resultado = Program.MedicosClinica.Adicionar(frmMedico.DadosMedico);

                if (resultado.Tipo == TipoResultado.OK)
                {
                    // Obter o ID do novo médico
                    int id = Program.MedicosClinica.IdUltimoRegistoInserido;

                    string nome = Program.MedicosClinica.Dados[id].Nome;
                    string especialidade = Program.MedicosClinica.Dados[id].EspecialidadeMedico.Designacao;

                    // Registar no  log
                    Log.AdicionarEvento(Log.TipoEvento.Info, $"Novo médico criado (ID: {id} - Nome: {nome} - Especialidade: {especialidade})");

                    MessageBox.Show("Novo médico criado com sucesso", "Criar Novo Médico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar lista de médicos
                    ListaMedicos.Items.Clear();
                    PopularListaMedicos();
                }
                else
                {
                    // Mostrar feedback caso tenha ocorrido um erro
                    MessageBox.Show("Ocorreu um erro ao tentar criar o novo médico", "Criar Novo Médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                    frmMedico.DadosMedico = Program.MedicosClinica.Dados[id];

                    // Mostrar a janela e verificar o resultado
                    if (frmMedico.ShowDialog() == DialogResult.OK)
                    {
                        ResultadoOperacao resultado = Program.MedicosClinica.Atualizar(frmMedico.DadosMedico);

                        if (resultado.Tipo == TipoResultado.OK)
                        {
                            string nome = Program.MedicosClinica.Dados[id].Nome;
                            string especialidade = Program.MedicosClinica.Dados[id].EspecialidadeMedico.Designacao;

                            // Registar no  log
                            Log.AdicionarEvento(Log.TipoEvento.Info, $"Dados do médico atualizados (ID: {id} - Nome: {nome} - Especialidade: {especialidade})");

                            MessageBox.Show("Dados do médico atualizados com sucesso", "Editar Médico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar lista de médicos
                            ListaMedicos.Items.Clear();
                            PopularListaMedicos();
                        }
                        else
                        {
                            // Mostrar feedback caso tenha ocorrido um erro
                            MessageBox.Show("Ocorreu um erro ao tentar editar os dados do médico", "Editar Médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            // Verificar que o utilizador selecionou um médico
            if (ListaMedicos.SelectedItems.Count > 0)
            {
                int id;

                if (int.TryParse(ListaMedicos.SelectedItems[0].SubItems[0].Text, out id))
                {
                    // Verificar se o médico selecionado tem marcações

                    // Percorrer todas as marcações existentes
                    foreach (Marcacao m in Program.MarcacoesClinica.Dados.Values)
                    {
                        // Verificar se a chave primária do médico selecionado é igual à chave
                        // primária do médico da marcação
                        if (m.MedicoMarcacao.Id == id)
                        {
                            MessageBox.Show("O médico selecionado não pode ser eliminado porque já existem marcações para este médico.", "Eliminar Médico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Cancelar a operação
                            return;
                        }
                    }

                    string nome = Program.MedicosClinica.Dados[id].Nome;
                    string especialidade = Program.MedicosClinica.Dados[id].EspecialidadeMedico.Designacao;

                    // Confirmar esta operação
                    if (MessageBox.Show($"Confirma a remoção do médico selecionado?\n\nMédico: {nome}\nEspecialidade: {especialidade}", "Eliminar Médico", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        ResultadoOperacao resultado = Program.MedicosClinica.Eliminar(id);

                        if (resultado.Tipo == TipoResultado.OK)
                        {
                            // Registar no  log
                            Log.AdicionarEvento(Log.TipoEvento.Info, $"Médico eliminado (Nome: {nome} - Especialidade: {especialidade})");

                            MessageBox.Show("Registo eliminado com sucesso", "Eliminar Médico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar a lista de médicos
                            ListaMedicos.Items.Clear();
                            PopularListaMedicos();
                        }
                        else
                        {
                            // Mostrar feedback caso tenha ocorrido um erro
                            MessageBox.Show("Ocorreu um erro ao tentar eliminar o médico", "Eliminar Médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
