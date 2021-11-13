
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutenticacao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.Utilizador = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LabelMensagemErro = new System.Windows.Forms.Label();
            this.LabelFundo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clínica Médica de Coimbra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autentique-se para aceder à aplicação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Utilizador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Password:";
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(243, 254);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 8;
            this.BotaoOk.Text = "&OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(324, 254);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 9;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // Utilizador
            // 
            this.Utilizador.Location = new System.Drawing.Point(102, 125);
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Size = new System.Drawing.Size(237, 22);
            this.Utilizador.TabIndex = 4;
            this.Utilizador.TextChanged += new System.EventHandler(this.Utilizador_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(101, 162);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 22);
            this.Password.TabIndex = 6;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LabelMensagemErro
            // 
            this.LabelMensagemErro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensagemErro.ForeColor = System.Drawing.Color.Red;
            this.LabelMensagemErro.Location = new System.Drawing.Point(99, 200);
            this.LabelMensagemErro.Name = "LabelMensagemErro";
            this.LabelMensagemErro.Size = new System.Drawing.Size(300, 42);
            this.LabelMensagemErro.TabIndex = 7;
            this.LabelMensagemErro.Text = "A autenticação falhou. Tente novamente.";
            // 
            // LabelFundo
            // 
            this.LabelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelFundo.Location = new System.Drawing.Point(0, 0);
            this.LabelFundo.Name = "LabelFundo";
            this.LabelFundo.Size = new System.Drawing.Size(411, 97);
            this.LabelFundo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = global::clinica_coimbra.Properties.Resources.application_icon32;
            this.pictureBox1.Location = new System.Drawing.Point(20, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelMensagemErro);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Utilizador);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAutenticacao";
            this.Load += new System.EventHandler(this.FormAutenticacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label LabelFundo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}