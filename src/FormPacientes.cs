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
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();

            // A janela deverá surgir no centro da aplicação
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.Text = "Pacientes";
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.MaximizeBox = false;
            this.MinimumSize = new Size(556, 455);
            this.SizeGripStyle = SizeGripStyle.Show;
            this.CancelButton = BotaoFechar;

            LabelFundo.Location = new Point(0, 0);
            LabelFundo.Width = this.ClientRectangle.Width;

            ListaPacientes.View = View.Details;
            ListaPacientes.FullRowSelect = true;
            // Acrescentar as colunas à lista de pacientes
            ListaPacientes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("Telefone", 80, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("NIF", 80, HorizontalAlignment.Left);
            ListaPacientes.Columns.Add("Sistema Saúde", -2, HorizontalAlignment.Left);

            // Popular a lista de pacientes com dados
            PopularListaPacientes();

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Inserir na lista de pacientes, todos os pacientes armazenados no sistema.
        /// </summary>
        private void PopularListaPacientes()
        {
            foreach (Paciente p in Program.PacientesClinica.Dados.Values)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Nome, p.Telefone, p.Nif, p.SistemaSaudePaciente.Designacao });
                ListaPacientes.Items.Add(item);
            }
        }

        /// <summary>
        /// Criar um novo paciente.
        /// </summary>
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormPaciente frmPaciente = new FormPaciente(TipoOperacao.Criar);

            // Mostrar a janela e verificar o resultado
            if (frmPaciente.ShowDialog() == DialogResult.OK)
            {
                ResultadoOperacao resultado = Program.PacientesClinica.Adicionar(frmPaciente.DadosPaciente);

                if (resultado.Tipo == TipoResultado.OK)
                {
                    // Obter o ID do novo paciente
                    int id = Program.PacientesClinica.IdUltimoRegistoInserido;

                    string nome = Program.PacientesClinica.Dados[id].Nome;
                    string nif = Program.PacientesClinica.Dados[id].Nif;

                    // Registar no  log
                    Log.AdicionarEvento(Log.TipoEvento.Info, $"Novo paciente criado (ID: {id} - Nome: {nome} - NIF: {nif})");

                    MessageBox.Show("Novo paciente criado com sucesso", "Criar Novo Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar a lista de pacientes
                    ListaPacientes.Items.Clear();
                    PopularListaPacientes();
                }
                else
                {
                    // Mostrar feedback caso tenha ocorrido um erro
                    MessageBox.Show("Ocorreu um erro ao tentar criar o novo paciente", "Criar Novo Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            frmPaciente.Dispose();
        }

        /// <summary>
        /// Editar os dados de um paciente.
        /// </summary>
        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            // Verificar se o utilizador selecionou um paciente da lista
            if (ListaPacientes.SelectedItems.Count > 0)
            {
                int id;

                // Obter o ID do paciente selecionado
                if (int.TryParse(ListaPacientes.SelectedItems[0].SubItems[0].Text, out id))
                {
                    FormPaciente frmPaciente = new FormPaciente(TipoOperacao.Editar);

                    frmPaciente.DadosPaciente = Program.PacientesClinica.Dados[id];

                    // Mostrar a janela e verificar o resultado
                    if (frmPaciente.ShowDialog() == DialogResult.OK)
                    {
                        ResultadoOperacao resultado = Program.PacientesClinica.Atualizar(frmPaciente.DadosPaciente);

                        if (resultado.Tipo == TipoResultado.OK)
                        {
                            string nome = Program.PacientesClinica.Dados[id].Nome;
                            string nif = Program.PacientesClinica.Dados[id].Nif;

                            // Registar no  log
                            Log.AdicionarEvento(Log.TipoEvento.Info, $"Dados do paciente atualizados (ID: {id} - Nome: {nome} - NIF: {nif})");

                            MessageBox.Show("Dados do paciente atualizados com sucesso", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar a lista de pacientes
                            ListaPacientes.Items.Clear();
                            PopularListaPacientes();
                        }
                        else
                        {
                            // Mostrar feedback caso tenha ocorrido um erro
                            MessageBox.Show("Ocorreu um erro ao tentar editar os dados do paciente", "Editar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    frmPaciente.Dispose();
                }
            }
        }

        /// <summary>
        /// Eliminar o paciente selecionado.
        /// </summary>
        private void BotaoEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que o utilizador selecionou um paciente
            if (ListaPacientes.SelectedItems.Count > 0)
            {
                int id;

                if (int.TryParse(ListaPacientes.SelectedItems[0].SubItems[0].Text, out id))
                {
                    // Verificar se o paciente selecionado tem marcações

                    // Percorrer todas as marcações existentes
                    foreach (Marcacao m in Program.MarcacoesClinica.Dados.Values)
                    {
                        // Verificar se a chave primária do paciente selecionado é igual à chave
                        // primária do paciente da marcação
                        if (m.PacienteMarcacao.Id == id)
                        {
                            MessageBox.Show("O paciente selecionado não pode ser eliminado porque já existem marcações para este paciente.", "Eliminar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Cancelar a operação
                            return;
                        }
                    }

                    string nome = Program.PacientesClinica.Dados[id].Nome;
                    string nif = Program.PacientesClinica.Dados[id].Nif;

                    // Confirmar esta operação
                    if (MessageBox.Show($"Confirma a remoção do paciente selecionado?\n\nPaciente: {nome} - NIF: {nif}", "Eliminar Paciente", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        ResultadoOperacao resultado = Program.PacientesClinica.Eliminar(id);

                        if (resultado.Tipo == TipoResultado.OK)
                        {
                            // Registar no  log
                            Log.AdicionarEvento(Log.TipoEvento.Info, $"Paciente eliminado (ID: {id} - Nome: {nome} - NIF: {nif})");

                            MessageBox.Show("Registo eliminado com sucesso", "Eliminar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar a lista de pacientes
                            ListaPacientes.Items.Clear();
                            PopularListaPacientes();
                        }
                        else
                        {
                            // Mostrar feedback caso tenha ocorrido um erro
                            MessageBox.Show("Ocorreu um erro ao tentar eliminar o paciente", "Eliminar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
