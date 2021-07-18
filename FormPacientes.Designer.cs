
namespace clinica_coimbra
{
    partial class FormPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFundo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaPacientes = new System.Windows.Forms.ListView();
            this.BotaoCriar = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoEliminar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFundo
            // 
            this.LabelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelFundo.Location = new System.Drawing.Point(0, 0);
            this.LabelFundo.Name = "LabelFundo";
            this.LabelFundo.Size = new System.Drawing.Size(528, 76);
            this.LabelFundo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pacientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clínica Médica de Coimbra";
            // 
            // ListaPacientes
            // 
            this.ListaPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaPacientes.HideSelection = false;
            this.ListaPacientes.Location = new System.Drawing.Point(12, 95);
            this.ListaPacientes.Name = "ListaPacientes";
            this.ListaPacientes.Size = new System.Drawing.Size(516, 280);
            this.ListaPacientes.TabIndex = 3;
            this.ListaPacientes.UseCompatibleStateImageBehavior = false;
            // 
            // BotaoCriar
            // 
            this.BotaoCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoCriar.Location = new System.Drawing.Point(12, 381);
            this.BotaoCriar.Name = "BotaoCriar";
            this.BotaoCriar.Size = new System.Drawing.Size(97, 23);
            this.BotaoCriar.TabIndex = 4;
            this.BotaoCriar.Text = "&Criar Paciente";
            this.BotaoCriar.UseVisualStyleBackColor = true;
            this.BotaoCriar.Click += new System.EventHandler(this.BotaoCriar_Click);
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoEditar.Location = new System.Drawing.Point(115, 381);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(97, 23);
            this.BotaoEditar.TabIndex = 5;
            this.BotaoEditar.Text = "&Editar Paciente";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // BotaoEliminar
            // 
            this.BotaoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoEliminar.Location = new System.Drawing.Point(218, 381);
            this.BotaoEliminar.Name = "BotaoEliminar";
            this.BotaoEliminar.Size = new System.Drawing.Size(97, 23);
            this.BotaoEliminar.TabIndex = 6;
            this.BotaoEliminar.Text = "El&iminar Paciente";
            this.BotaoEliminar.UseVisualStyleBackColor = true;
            this.BotaoEliminar.Click += new System.EventHandler(this.BotaoEliminar_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.Location = new System.Drawing.Point(453, 381);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 7;
            this.BotaoFechar.Text = "&Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 416);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoEliminar);
            this.Controls.Add(this.BotaoEditar);
            this.Controls.Add(this.BotaoCriar);
            this.Controls.Add(this.ListaPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaPacientes;
        private System.Windows.Forms.Button BotaoCriar;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoEliminar;
        private System.Windows.Forms.Button BotaoFechar;
    }
}