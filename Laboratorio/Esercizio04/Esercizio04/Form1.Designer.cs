namespace Esercizio04
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserisciStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneClassiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaSuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaDaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbStudente = new System.Windows.Forms.GroupBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.cmbSpecializzazione = new System.Windows.Forms.ComboBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMatricola = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grbClasse = new System.Windows.Forms.GroupBox();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.grbRicerca = new System.Windows.Forms.GroupBox();
            this.nudRicercaMatricola = new System.Windows.Forms.NumericUpDown();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.txtRicercaNome = new System.Windows.Forms.TextBox();
            this.txtRicercaCognome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbDatiStudente = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblDDN = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbStudente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).BeginInit();
            this.grbClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.grbRicerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicercaMatricola)).BeginInit();
            this.grbDatiStudente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciStudenteToolStripMenuItem,
            this.gestioneStudentiToolStripMenuItem,
            this.gestioneClassiToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserisciStudenteToolStripMenuItem
            // 
            this.inserisciStudenteToolStripMenuItem.Name = "inserisciStudenteToolStripMenuItem";
            this.inserisciStudenteToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.inserisciStudenteToolStripMenuItem.Text = "Inserisci studente";
            this.inserisciStudenteToolStripMenuItem.Click += new System.EventHandler(this.inserisciStudenteToolStripMenuItem_Click);
            // 
            // gestioneStudentiToolStripMenuItem
            // 
            this.gestioneStudentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ricercaToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.gestioneStudentiToolStripMenuItem.Name = "gestioneStudentiToolStripMenuItem";
            this.gestioneStudentiToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.gestioneStudentiToolStripMenuItem.Text = "Gestione studenti";
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ricercaToolStripMenuItem.Text = "Ricerca";
            this.ricercaToolStripMenuItem.Click += new System.EventHandler(this.ricercaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // gestioneClassiToolStripMenuItem
            // 
            this.gestioneClassiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaToolStripMenuItem,
            this.ordinaAZToolStripMenuItem,
            this.salvaSuFileToolStripMenuItem,
            this.caricaDaFileToolStripMenuItem});
            this.gestioneClassiToolStripMenuItem.Name = "gestioneClassiToolStripMenuItem";
            this.gestioneClassiToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestioneClassiToolStripMenuItem.Text = "Gestione Classi";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.visualizzaToolStripMenuItem.Text = "Visualizza ";
            this.visualizzaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaToolStripMenuItem_Click);
            // 
            // ordinaAZToolStripMenuItem
            // 
            this.ordinaAZToolStripMenuItem.Name = "ordinaAZToolStripMenuItem";
            this.ordinaAZToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ordinaAZToolStripMenuItem.Text = "Ordina (A..Z)";
            // 
            // salvaSuFileToolStripMenuItem
            // 
            this.salvaSuFileToolStripMenuItem.Name = "salvaSuFileToolStripMenuItem";
            this.salvaSuFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salvaSuFileToolStripMenuItem.Text = "Salva su File";
            this.salvaSuFileToolStripMenuItem.Click += new System.EventHandler(this.salvaSuFileToolStripMenuItem_Click);
            // 
            // caricaDaFileToolStripMenuItem
            // 
            this.caricaDaFileToolStripMenuItem.Name = "caricaDaFileToolStripMenuItem";
            this.caricaDaFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.caricaDaFileToolStripMenuItem.Text = "Carica da File";
            this.caricaDaFileToolStripMenuItem.Click += new System.EventHandler(this.caricaDaFileToolStripMenuItem_Click);
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
            this.grbStudente.Controls.Add(this.btnAnnulla);
            this.grbStudente.Controls.Add(this.btnInserisci);
            this.grbStudente.Controls.Add(this.dtpDataNascita);
            this.grbStudente.Controls.Add(this.cmbSpecializzazione);
            this.grbStudente.Controls.Add(this.cmbClasse);
            this.grbStudente.Controls.Add(this.label6);
            this.grbStudente.Controls.Add(this.label5);
            this.grbStudente.Controls.Add(this.label4);
            this.grbStudente.Controls.Add(this.txtNome);
            this.grbStudente.Controls.Add(this.label3);
            this.grbStudente.Controls.Add(this.txtCognome);
            this.grbStudente.Controls.Add(this.label2);
            this.grbStudente.Controls.Add(this.nudMatricola);
            this.grbStudente.Controls.Add(this.label1);
            this.grbStudente.Enabled = false;
            this.grbStudente.Location = new System.Drawing.Point(12, 27);
            this.grbStudente.Name = "grbStudente";
            this.grbStudente.Size = new System.Drawing.Size(600, 271);
            this.grbStudente.TabIndex = 1;
            this.grbStudente.TabStop = false;
            this.grbStudente.Text = "Inserimento nuovo studente";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Salmon;
            this.btnAnnulla.Location = new System.Drawing.Point(333, 177);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(208, 38);
            this.btnAnnulla.TabIndex = 13;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.Color.LightGreen;
            this.btnInserisci.Location = new System.Drawing.Point(56, 177);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(208, 38);
            this.btnInserisci.TabIndex = 12;
            this.btnInserisci.Text = "Inserisci ";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(333, 31);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(206, 20);
            this.dtpDataNascita.TabIndex = 11;
            // 
            // cmbSpecializzazione
            // 
            this.cmbSpecializzazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecializzazione.FormattingEnabled = true;
            this.cmbSpecializzazione.Location = new System.Drawing.Point(354, 112);
            this.cmbSpecializzazione.Name = "cmbSpecializzazione";
            this.cmbSpecializzazione.Size = new System.Drawing.Size(185, 21);
            this.cmbSpecializzazione.TabIndex = 10;
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
            this.cmbClasse.Location = new System.Drawing.Point(333, 73);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(206, 21);
            this.cmbClasse.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Specializzazione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Classe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data nascita";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(74, 73);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(158, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // nudMatricola
            // 
            this.nudMatricola.Location = new System.Drawing.Point(74, 31);
            this.nudMatricola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMatricola.Name = "nudMatricola";
            this.nudMatricola.Size = new System.Drawing.Size(158, 20);
            this.nudMatricola.TabIndex = 1;
            this.nudMatricola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N.Matricola";
            // 
            // grbClasse
            // 
            this.grbClasse.Controls.Add(this.dgvClasse);
            this.grbClasse.Location = new System.Drawing.Point(15, 308);
            this.grbClasse.Name = "grbClasse";
            this.grbClasse.Size = new System.Drawing.Size(597, 180);
            this.grbClasse.TabIndex = 2;
            this.grbClasse.TabStop = false;
            this.grbClasse.Text = "Visualizzazione classe";
            // 
            // dgvClasse
            // 
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Location = new System.Drawing.Point(6, 18);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.Size = new System.Drawing.Size(584, 150);
            this.dgvClasse.TabIndex = 0;
            // 
            // grbRicerca
            // 
            this.grbRicerca.Controls.Add(this.nudRicercaMatricola);
            this.grbRicerca.Controls.Add(this.btnRicerca);
            this.grbRicerca.Controls.Add(this.txtRicercaNome);
            this.grbRicerca.Controls.Add(this.txtRicercaCognome);
            this.grbRicerca.Controls.Add(this.label9);
            this.grbRicerca.Controls.Add(this.label8);
            this.grbRicerca.Controls.Add(this.label7);
            this.grbRicerca.Location = new System.Drawing.Point(619, 28);
            this.grbRicerca.Name = "grbRicerca";
            this.grbRicerca.Size = new System.Drawing.Size(223, 214);
            this.grbRicerca.TabIndex = 3;
            this.grbRicerca.TabStop = false;
            this.grbRicerca.Text = "Ricerca Studente";
            // 
            // nudRicercaMatricola
            // 
            this.nudRicercaMatricola.Location = new System.Drawing.Point(116, 47);
            this.nudRicercaMatricola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRicercaMatricola.Name = "nudRicercaMatricola";
            this.nudRicercaMatricola.Size = new System.Drawing.Size(92, 20);
            this.nudRicercaMatricola.TabIndex = 7;
            this.nudRicercaMatricola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRicerca
            // 
            this.btnRicerca.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRicerca.Location = new System.Drawing.Point(6, 176);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(202, 31);
            this.btnRicerca.TabIndex = 6;
            this.btnRicerca.Text = "Ricerca";
            this.btnRicerca.UseVisualStyleBackColor = false;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // txtRicercaNome
            // 
            this.txtRicercaNome.Location = new System.Drawing.Point(101, 123);
            this.txtRicercaNome.Name = "txtRicercaNome";
            this.txtRicercaNome.Size = new System.Drawing.Size(107, 20);
            this.txtRicercaNome.TabIndex = 5;
            // 
            // txtRicercaCognome
            // 
            this.txtRicercaCognome.Location = new System.Drawing.Point(101, 85);
            this.txtRicercaCognome.Name = "txtRicercaCognome";
            this.txtRicercaCognome.Size = new System.Drawing.Size(107, 20);
            this.txtRicercaCognome.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ricerca Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ricerca Cognome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ricerca N. Matricola";
            // 
            // grbDatiStudente
            // 
            this.grbDatiStudente.Controls.Add(this.button1);
            this.grbDatiStudente.Controls.Add(this.lblSpec);
            this.grbDatiStudente.Controls.Add(this.lblClasse);
            this.grbDatiStudente.Controls.Add(this.lblDDN);
            this.grbDatiStudente.Controls.Add(this.lblCognome);
            this.grbDatiStudente.Controls.Add(this.lblNome);
            this.grbDatiStudente.Controls.Add(this.lblMatricola);
            this.grbDatiStudente.Location = new System.Drawing.Point(848, 28);
            this.grbDatiStudente.Name = "grbDatiStudente";
            this.grbDatiStudente.Size = new System.Drawing.Size(191, 214);
            this.grbDatiStudente.TabIndex = 4;
            this.grbDatiStudente.TabStop = false;
            this.grbDatiStudente.Text = "Dati studente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpec.Location = new System.Drawing.Point(74, 167);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(49, 13);
            this.lblSpec.TabIndex = 6;
            this.lblSpec.Text = "lblSpec";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(7, 167);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(41, 13);
            this.lblClasse.TabIndex = 5;
            this.lblClasse.Text = "label15";
            // 
            // lblDDN
            // 
            this.lblDDN.AutoSize = true;
            this.lblDDN.Location = new System.Drawing.Point(7, 130);
            this.lblDDN.Name = "lblDDN";
            this.lblDDN.Size = new System.Drawing.Size(41, 13);
            this.lblDDN.TabIndex = 4;
            this.lblDDN.Text = "label14";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(74, 92);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(48, 13);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "label13";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label12";
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricola.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMatricola.Location = new System.Drawing.Point(7, 48);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(48, 13);
            this.lblMatricola.TabIndex = 0;
            this.lblMatricola.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 522);
            this.Controls.Add(this.grbDatiStudente);
            this.Controls.Add(this.grbRicerca);
            this.Controls.Add(this.grbClasse);
            this.Controls.Add(this.grbStudente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Esercizio4 - Gestione STUDENTI/CLASSI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbStudente.ResumeLayout(false);
            this.grbStudente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatricola)).EndInit();
            this.grbClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            this.grbRicerca.ResumeLayout(false);
            this.grbRicerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicercaMatricola)).EndInit();
            this.grbDatiStudente.ResumeLayout(false);
            this.grbDatiStudente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserisciStudenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ricercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneClassiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordinaAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaSuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaDaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grbStudente;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.ComboBox cmbSpecializzazione;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMatricola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.GroupBox grbClasse;
        private System.Windows.Forms.DataGridView dgvClasse;
        private System.Windows.Forms.GroupBox grbRicerca;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.TextBox txtRicercaNome;
        private System.Windows.Forms.TextBox txtRicercaCognome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbDatiStudente;
        private System.Windows.Forms.NumericUpDown nudRicercaMatricola;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblDDN;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSpec;
    }
}