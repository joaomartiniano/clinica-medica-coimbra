
namespace clinica_coimbra
{
    partial class FormMarcacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaPacientes = new System.Windows.Forms.ListView();
            this.ListaMedicos = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.BotaoConfirmar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.LabelFundo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Médico:";
            // 
            // ListaPacientes
            // 
            this.ListaPacientes.HideSelection = false;
            this.ListaPacientes.Location = new System.Drawing.Point(12, 152);
            this.ListaPacientes.Name = "ListaPacientes";
            this.ListaPacientes.Size = new System.Drawing.Size(373, 242);
            this.ListaPacientes.TabIndex = 8;
            this.ListaPacientes.UseCompatibleStateImageBehavior = false;
            // 
            // ListaMedicos
            // 
            this.ListaMedicos.HideSelection = false;
            this.ListaMedicos.Location = new System.Drawing.Point(404, 152);
            this.ListaMedicos.Name = "ListaMedicos";
            this.ListaMedicos.Size = new System.Drawing.Size(371, 242);
            this.ListaMedicos.TabIndex = 10;
            this.ListaMedicos.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Data da Marcação:";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(120, 90);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(250, 22);
            this.Data.TabIndex = 4;
            // 
            // BotaoConfirmar
            // 
            this.BotaoConfirmar.Location = new System.Drawing.Point(619, 413);
            this.BotaoConfirmar.Name = "BotaoConfirmar";
            this.BotaoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BotaoConfirmar.TabIndex = 11;
            this.BotaoConfirmar.Text = "C&onfirmar";
            this.BotaoConfirmar.UseVisualStyleBackColor = true;
            this.BotaoConfirmar.Click += new System.EventHandler(this.BotaoConfirmar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(700, 413);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 12;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // LabelFundo
            // 
            this.LabelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelFundo.Location = new System.Drawing.Point(-2, -1);
            this.LabelFundo.Name = "LabelFundo";
            this.LabelFundo.Size = new System.Drawing.Size(788, 76);
            this.LabelFundo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marcações de Consultas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Clínica Médica de Coimbra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Hora da Marcação:";
            // 
            // Hora
            // 
            this.Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora.Location = new System.Drawing.Point(510, 90);
            this.Hora.Name = "Hora";
            this.Hora.ShowUpDown = true;
            this.Hora.Size = new System.Drawing.Size(76, 22);
            this.Hora.TabIndex = 6;
            // 
            // FormMarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 448);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelFundo);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoConfirmar);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaMedicos);
            this.Controls.Add(this.ListaPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMarcacao";
            this.Text = "FormMarcacao";
            this.Load += new System.EventHandler(this.FormMarcacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListaPacientes;
        private System.Windows.Forms.ListView ListaMedicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Button BotaoConfirmar;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Label LabelFundo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Hora;
    }
}