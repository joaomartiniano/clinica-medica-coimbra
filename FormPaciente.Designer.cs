
namespace clinica_coimbra
{
    partial class FormPaciente
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
            this.LabelMensagem = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Morada = new System.Windows.Forms.TextBox();
            this.CodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.BotaoOK = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.Nif = new System.Windows.Forms.TextBox();
            this.ListaSistemasSaude = new System.Windows.Forms.ComboBox();
            this.NumeroSistemaSaude = new System.Windows.Forms.TextBox();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMensagem
            // 
            this.LabelMensagem.AutoSize = true;
            this.LabelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensagem.Location = new System.Drawing.Point(11, 9);
            this.LabelMensagem.Name = "LabelMensagem";
            this.LabelMensagem.Size = new System.Drawing.Size(242, 20);
            this.LabelMensagem.TabIndex = 0;
            this.LabelMensagem.Text = "Insira os dados do novo paciente";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(33, 48);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(38, 13);
            this.LabelID.TabIndex = 2;
            this.LabelID.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "&Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Morada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código &Postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "&Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de &Identificação Fiscal (NIF):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "&Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sistema de &Saúde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Número de &Beneficiário/Utente:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(86, 71);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(469, 22);
            this.Nome.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(273, 105);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(282, 22);
            this.Email.TabIndex = 8;
            // 
            // Morada
            // 
            this.Morada.Location = new System.Drawing.Point(86, 139);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(286, 22);
            this.Morada.TabIndex = 10;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Location = new System.Drawing.Point(466, 139);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(89, 22);
            this.CodigoPostal.TabIndex = 12;
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(86, 105);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(110, 22);
            this.Telefone.TabIndex = 6;
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(399, 374);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(75, 23);
            this.BotaoOK.TabIndex = 18;
            this.BotaoOK.Text = "&OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(480, 374);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 19;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // Nif
            // 
            this.Nif.Location = new System.Drawing.Point(211, 173);
            this.Nif.Name = "Nif";
            this.Nif.Size = new System.Drawing.Size(161, 22);
            this.Nif.TabIndex = 14;
            // 
            // ListaSistemasSaude
            // 
            this.ListaSistemasSaude.FormattingEnabled = true;
            this.ListaSistemasSaude.Location = new System.Drawing.Point(127, 31);
            this.ListaSistemasSaude.Name = "ListaSistemasSaude";
            this.ListaSistemasSaude.Size = new System.Drawing.Size(306, 21);
            this.ListaSistemasSaude.TabIndex = 1;
            // 
            // NumeroSistemaSaude
            // 
            this.NumeroSistemaSaude.Location = new System.Drawing.Point(196, 62);
            this.NumeroSistemaSaude.Name = "NumeroSistemaSaude";
            this.NumeroSistemaSaude.Size = new System.Drawing.Size(237, 22);
            this.NumeroSistemaSaude.TabIndex = 3;
            // 
            // DataNascimento
            // 
            this.DataNascimento.Location = new System.Drawing.Point(131, 334);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(261, 22);
            this.DataNascimento.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ListaSistemasSaude);
            this.groupBox1.Controls.Add(this.NumeroSistemaSaude);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(15, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema/Subsistema de Saúde";
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.Nif);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.CodigoPostal);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelMensagem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPaciente";
            this.Text = "FormPaciente";
            this.Load += new System.EventHandler(this.FormPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMensagem;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Morada;
        private System.Windows.Forms.MaskedTextBox CodigoPostal;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.TextBox Nif;
        private System.Windows.Forms.ComboBox ListaSistemasSaude;
        private System.Windows.Forms.TextBox NumeroSistemaSaude;
        private System.Windows.Forms.DateTimePicker DataNascimento;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}