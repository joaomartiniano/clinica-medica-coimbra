
namespace clinica_coimbra
{
    partial class FormMedico
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
            this.BotaoOK = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaEspecialidades = new System.Windows.Forms.ComboBox();
            this.LabelMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(214, 147);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(75, 23);
            this.BotaoOK.TabIndex = 7;
            this.BotaoOK.Text = "&OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(295, 147);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 8;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
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
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(33, 48);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(38, 13);
            this.LabelID.TabIndex = 2;
            this.LabelID.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Nome:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(94, 76);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(276, 22);
            this.Nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Especialidade:";
            // 
            // ListaEspecialidades
            // 
            this.ListaEspecialidades.FormattingEnabled = true;
            this.ListaEspecialidades.Location = new System.Drawing.Point(94, 102);
            this.ListaEspecialidades.Name = "ListaEspecialidades";
            this.ListaEspecialidades.Size = new System.Drawing.Size(276, 21);
            this.ListaEspecialidades.TabIndex = 6;
            // 
            // LabelMensagem
            // 
            this.LabelMensagem.AutoSize = true;
            this.LabelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensagem.Location = new System.Drawing.Point(11, 9);
            this.LabelMensagem.Name = "LabelMensagem";
            this.LabelMensagem.Size = new System.Drawing.Size(232, 20);
            this.LabelMensagem.TabIndex = 0;
            this.LabelMensagem.Text = "Insira os dados do novo médico";
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 182);
            this.Controls.Add(this.LabelMensagem);
            this.Controls.Add(this.ListaEspecialidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOK);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMedico";
            this.Text = "FormMedico";
            this.Load += new System.EventHandler(this.FormMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ListaEspecialidades;
        private System.Windows.Forms.Label LabelMensagem;
    }
}