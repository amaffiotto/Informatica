namespace Esercizio04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserisciStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaSuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaDaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbStudente = new System.Windows.Forms.GroupBox();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.nudMatricola = new System.Windows.Forms.NumericUpDown();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDDN = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblSpecializzazione = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSpecializzazione = new System.Windows.Forms.ComboBox();
            this.btnAnulla = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grbStudente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciStudenteToolStripMenuItem,
            this.gestioneStudentiToolStripMenuItem,
            this.gestioneClasseToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserisciStudenteToolStripMenuItem
            // 
            this.inserisciStudenteToolStripMenuItem.Name = "inserisciStudenteToolStripMenuItem";
            this.inserisciStudenteToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.inserisciStudenteToolStripMenuItem.Text = "Inserisci Studente";
            this.inserisciStudenteToolStripMenuItem.Click += new System.EventHandler(this.inserisciStudenteToolStripMenuItem_Click);
            // 
            // gestioneStudentiToolStripMenuItem
            // 
            this.gestioneStudentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ricercaToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.gestioneStudentiToolStripMenuItem.Name = "gestioneStudentiToolStripMenuItem";
            this.gestioneStudentiToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestioneStudentiToolStripMenuItem.Text = "Gestione Studenti";
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ricercaToolStripMenuItem.Text = "Ricerca";
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // gestioneClasseToolStripMenuItem
            // 
            this.gestioneClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaToolStripMenuItem,
            this.ordinaAZToolStripMenuItem,
            this.salvaSuFileToolStripMenuItem,
            this.caricaDaFileToolStripMenuItem});
            this.gestioneClasseToolStripMenuItem.Name = "gestioneClasseToolStripMenuItem";
            this.gestioneClasseToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gestioneClasseToolStripMenuItem.Text = "Gestione Classe";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            // 
            // ordinaAZToolStripMenuItem
            // 
            this.ordinaAZToolStripMenuItem.Name = "ordinaAZToolStripMenuItem";
            this.ordinaAZToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ordinaAZToolStripMenuItem.Text = "Ordina (A .. Z)";
            // 
            // salvaSuFileToolStripMenuItem
            // 
            this.salvaSuFileToolStripMenuItem.Name = "salvaSuFileToolStripMenuItem";
            this.salvaSuFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salvaSuFileToolStripMenuItem.Text = "Salva su File";
            // 
            // caricaDaFileToolStripMenuItem
            // 
            this.caricaDaFileToolStripMenuItem.Name = "caricaDaFileToolStripMenuItem";
            this.caricaDaFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.caricaDaFileToolStripMenuItem.Text = "Carica da File";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // grbStudente
            // 
            this.grbStudente.Controls.Add(this.btnInserisci);
            this.grbStudente.Controls.Add(this.btnAnulla);
            this.grbStudente.Controls.Add(this.cmbSpecializzazione);
            this.grbStudente.Controls.Add(this.cmbClasse);
            this.grbStudente.Controls.Add(this.dtpDataDiNascita);
            this.grbStudente.Controls.Add(this.txtNome);
            this.grbStudente.Controls.Add(this.txtCognome);
            this.grbStudente.Controls.Add(this.lblSpecializzazione);
            this.grbStudente.Controls.Add(this.lblClasse);
            this.grbStudente.Controls.Add(this.lblDDN);
            this.grbStudente.Controls.Add(this.lblNome);
            this.grbStudente.Controls.Add(this.lblCognome);
            this.grbStudente.Controls.Add(this.nudMatricola);
            this.grbStudente.Controls.Add(this.lblMatricola);
            this.grbStudente.Location = new System.Drawing.Point(12, 27);
            this.grbStudente.Name = "grbStudente";
            this.grbStudente.Size = new System.Drawing.Size(534, 253);
            this.grbStudente.TabIndex = 1;
            this.grbStudente.TabStop = false;
            this.grbStudente.Text = "Inserimento Nuovo Studente";
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Location = new System.Drawing.Point(19, 41);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(64, 13);
            this.lblMatricola.TabIndex = 0;
            this.lblMatricola.Text = "N. Matricola";
            // 
            // nudMatricola
            // 
            this.nudMatricola.Location = new System.Drawing.Point(89, 39);
            this.nudMatricola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMatricola.Name = "nudMatricola";
            this.nudMatricola.Size = new System.Drawing.Size(65, 20);
            this.nudMatricola.TabIndex = 1;
            this.nudMatricola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(19, 83);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "Cognome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 131);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblDDN
            // 
            this.lblDDN.AutoSize = true;
            this.lblDDN.Location = new System.Drawing.Point(246, 41);
            this.lblDDN.Name = "lblDDN";
            this.lblDDN.Size = new System.Drawing.Size(82, 13);
            this.lblDDN.TabIndex = 4;
            this.lblDDN.Text = "Data Di Nascita";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(246, 83);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(38, 13);
            this.lblClasse.TabIndex = 5;
            this.lblClasse.Text = "Classe";
            // 
            // lblSpecializzazione
            // 
            this.lblSpecializzazione.AutoSize = true;
            this.lblSpecializzazione.Location = new System.Drawing.Point(246, 131);
            this.lblSpecializzazione.Name = "lblSpecializzazione";
            this.lblSpecializzazione.Size = new System.Drawing.Size(85, 13);
            this.lblSpecializzazione.TabIndex = 6;
            this.lblSpecializzazione.Text = "Specializzazione";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(89, 80);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(127, 20);
            this.txtCognome.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(127, 20);
            this.txtNome.TabIndex = 8;
            // 
            // dtpDataDiNascita
            // 
            this.dtpDataDiNascita.Location = new System.Drawing.Point(334, 39);
            this.dtpDataDiNascita.Name = "dtpDataDiNascita";
            this.dtpDataDiNascita.Size = new System.Drawing.Size(181, 20);
            this.dtpDataDiNascita.TabIndex = 9;
            // 
            // cmbClasse
            // 
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "4A",
            "4B",
            "4C",
            "4D",
            "4E",
            "5A",
            "5B",
            "5C",
            "5D",
            "5E"});
            this.cmbClasse.Location = new System.Drawing.Point(334, 79);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(66, 21);
            this.cmbClasse.TabIndex = 10;
            // 
            // cmbSpecializzazione
            // 
            this.cmbSpecializzazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecializzazione.FormattingEnabled = true;
            this.cmbSpecializzazione.Location = new System.Drawing.Point(334, 127);
            this.cmbSpecializzazione.Name = "cmbSpecializzazione";
            this.cmbSpecializzazione.Size = new System.Drawing.Size(66, 21);
            this.cmbSpecializzazione.TabIndex = 11;
            // 
            // btnAnulla
            // 
            this.btnAnulla.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnulla.Location = new System.Drawing.Point(344, 224);
            this.btnAnulla.Name = "btnAnulla";
            this.btnAnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnulla.TabIndex = 12;
            this.btnAnulla.Text = "Anulla";
            this.btnAnulla.UseVisualStyleBackColor = false;
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInserisci.Location = new System.Drawing.Point(440, 224);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 13;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbStudente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Esercizio 4 - Gestione STUDENTI/CLASSI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbStudente.ResumeLayout(false);
            this.grbStudente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserisciStudenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ricercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordinaAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaSuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaDaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grbStudente;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblSpecializzazione;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblDDN;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.NumericUpDown nudMatricola;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnAnulla;
        private System.Windows.Forms.ComboBox cmbSpecializzazione;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.DateTimePicker dtpDataDiNascita;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

