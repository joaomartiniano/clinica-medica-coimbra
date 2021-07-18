
namespace clinica_coimbra
{
    partial class FormAutenticacao
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.Utilizador = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LabelMensagemErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clínica Médica de Coimbra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autentique-se para aceder à aplicação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utilizador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(243, 239);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 6;
            this.BotaoOk.Text = "OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(324, 239);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 7;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // Utilizador
            // 
            this.Utilizador.Location = new System.Drawing.Point(102, 125);
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Size = new System.Drawing.Size(237, 22);
            this.Utilizador.TabIndex = 3;
            this.Utilizador.TextChanged += new System.EventHandler(this.Utilizador_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(101, 162);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 22);
            this.Password.TabIndex = 5;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LabelMensagemErro
            // 
            this.LabelMensagemErro.AutoSize = true;
            this.LabelMensagemErro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensagemErro.ForeColor = System.Drawing.Color.Red;
            this.LabelMensagemErro.Location = new System.Drawing.Point(99, 200);
            this.LabelMensagemErro.Name = "LabelMensagemErro";
            this.LabelMensagemErro.Size = new System.Drawing.Size(220, 13);
            this.LabelMensagemErro.TabIndex = 8;
            this.LabelMensagemErro.Text = "A autenticação falhou. Tente novamente.";
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 274);
            this.Controls.Add(this.LabelMensagemErro);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Utilizador);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAutenticacao";
            this.Load += new System.EventHandler(this.FormAutenticacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BotaoOk;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.TextBox Utilizador;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label LabelMensagemErro;
    }
}