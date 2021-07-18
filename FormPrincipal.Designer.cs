
namespace clinica_coimbra
{
    partial class FormPrincipal
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange51 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange52 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange53 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange54 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange55 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Calendario = new System.Windows.Forms.Calendar.Calendar();
            this.CalendarioMeses = new System.Windows.Forms.Calendar.MonthView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDaAplicacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.IconePacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BotaoNovaMarcacao = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFundo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendario.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            calendarHighlightRange51.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange51.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange51.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange52.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange52.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange52.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange53.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange53.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange53.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange54.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange54.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange54.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange55.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange55.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange55.StartTime = System.TimeSpan.Parse("08:00:00");
            this.Calendario.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange51,
        calendarHighlightRange52,
        calendarHighlightRange53,
        calendarHighlightRange54,
        calendarHighlightRange55};
            this.Calendario.Location = new System.Drawing.Point(227, 93);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(573, 430);
            this.Calendario.TabIndex = 1;
            this.Calendario.Text = "calendar1";
            this.Calendario.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.Calendario_LoadItems);
            // 
            // CalendarioMeses
            // 
            this.CalendarioMeses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CalendarioMeses.ArrowsColor = System.Drawing.SystemColors.Window;
            this.CalendarioMeses.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.CalendarioMeses.DayBackgroundColor = System.Drawing.Color.Empty;
            this.CalendarioMeses.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.CalendarioMeses.DayNamesLength = 3;
            this.CalendarioMeses.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.CalendarioMeses.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.CalendarioMeses.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.CalendarioMeses.ItemPadding = new System.Windows.Forms.Padding(2);
            this.CalendarioMeses.Location = new System.Drawing.Point(0, 52);
            this.CalendarioMeses.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalendarioMeses.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.CalendarioMeses.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalendarioMeses.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.CalendarioMeses.Name = "CalendarioMeses";
            this.CalendarioMeses.Size = new System.Drawing.Size(221, 471);
            this.CalendarioMeses.TabIndex = 2;
            this.CalendarioMeses.Text = "monthView1";
            this.CalendarioMeses.TodayBorderColor = System.Drawing.Color.Maroon;
            this.CalendarioMeses.SelectionChanged += new System.EventHandler(this.CalendarioMeses_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.dadosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.médicosToolStripMenuItem});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dadosToolStripMenuItem.Text = "&Dados";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pacientesToolStripMenuItem.Text = "&Pacientes...";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.médicosToolStripMenuItem.Text = "&Médicos...";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDaAplicacaoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // acercaDaAplicacaoToolStripMenuItem
            // 
            this.acercaDaAplicacaoToolStripMenuItem.Name = "acercaDaAplicacaoToolStripMenuItem";
            this.acercaDaAplicacaoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.acercaDaAplicacaoToolStripMenuItem.Text = "Ac&erca da Aplicação";
            this.acercaDaAplicacaoToolStripMenuItem.Click += new System.EventHandler(this.acercaDaAplicacaoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.IconePacientes,
            this.toolStripSeparator1,
            this.BotaoNovaMarcacao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // IconePacientes
            // 
            this.IconePacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconePacientes.Image = ((System.Drawing.Image)(resources.GetObject("IconePacientes.Image")));
            this.IconePacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconePacientes.Name = "IconePacientes";
            this.IconePacientes.Size = new System.Drawing.Size(23, 22);
            this.IconePacientes.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BotaoNovaMarcacao
            // 
            this.BotaoNovaMarcacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BotaoNovaMarcacao.Image = ((System.Drawing.Image)(resources.GetObject("BotaoNovaMarcacao.Image")));
            this.BotaoNovaMarcacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotaoNovaMarcacao.Name = "BotaoNovaMarcacao";
            this.BotaoNovaMarcacao.Size = new System.Drawing.Size(94, 22);
            this.BotaoNovaMarcacao.Text = "Nova Marcação";
            this.BotaoNovaMarcacao.Click += new System.EventHandler(this.BotaoNovaMarcacao_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(583, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clínica Médica de Coimbra";
            // 
            // LabelFundo
            // 
            this.LabelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelFundo.Location = new System.Drawing.Point(224, 52);
            this.LabelFundo.Name = "LabelFundo";
            this.LabelFundo.Size = new System.Drawing.Size(576, 38);
            this.LabelFundo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marcações da Semana";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFundo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CalendarioMeses);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Calendar.Calendar Calendario;
        private System.Windows.Forms.Calendar.MonthView CalendarioMeses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton IconePacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BotaoNovaMarcacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDaAplicacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.Label LabelFundo;
        private System.Windows.Forms.Label label2;
    }
}

