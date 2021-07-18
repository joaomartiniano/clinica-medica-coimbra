
namespace clinica_coimbra
{
    partial class FormAcerca
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
            this.BotaoOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Link1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Link2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelFundo
            // 
            this.LabelFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelFundo.Location = new System.Drawing.Point(0, 0);
            this.LabelFundo.Name = "LabelFundo";
            this.LabelFundo.Size = new System.Drawing.Size(593, 146);
            this.LabelFundo.TabIndex = 0;
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(507, 286);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(75, 23);
            this.BotaoOK.TabIndex = 1;
            this.BotaoOK.Text = "&OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clínica Médica de Coimbra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aplicação de Gestão (versão 1.0.0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "© 2021 João Martiniano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Componentes utilizados:";
            // 
            // Link1
            // 
            this.Link1.AutoSize = true;
            this.Link1.Location = new System.Drawing.Point(180, 191);
            this.Link1.Name = "Link1";
            this.Link1.Size = new System.Drawing.Size(240, 13);
            this.Link1.TabIndex = 6;
            this.Link1.TabStop = true;
            this.Link1.Text = "https://dev.mysql.com/doc/connector-net/en/";
            this.Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "MySQL Connector/NET:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Winforms Calendar:";
            // 
            // Link2
            // 
            this.Link2.Location = new System.Drawing.Point(180, 216);
            this.Link2.Name = "Link2";
            this.Link2.Size = new System.Drawing.Size(381, 36);
            this.Link2.TabIndex = 9;
            this.Link2.TabStop = true;
            this.Link2.Text = "https://www.codeproject.com/Articles/38699/A-Professional-Calendar-Agenda-View-Th" +
    "at-You-Will";
            this.Link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link2_LinkClicked);
            // 
            // FormAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 321);
            this.Controls.Add(this.Link2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Link1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.LabelFundo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAcerca";
            this.Text = "FormAcerca";
            this.Load += new System.EventHandler(this.FormAcerca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFundo;
        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Link1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel Link2;
    }
}