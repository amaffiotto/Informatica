namespace MaffiottoBilblioteca
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aggiungiPubblicazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rivistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercaPerTitoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcolaPrezzoMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAddPubblicazione = new System.Windows.Forms.GroupBox();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.btnAddPubblicazione = new System.Windows.Forms.Button();
            this.nudVariabile = new System.Windows.Forms.NumericUpDown();
            this.lblVariabile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Titolo = new System.Windows.Forms.Label();
            this.txtAddAutore = new System.Windows.Forms.TextBox();
            this.txtAddTitolo = new System.Windows.Forms.TextBox();
            this.grbViewCatalog = new System.Windows.Forms.GroupBox();
            this.dgvViewCatalog = new System.Windows.Forms.DataGridView();
            this.grbCercaPerTitolo = new System.Windows.Forms.GroupBox();
            this.btnCercaPerTitolo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCercaPerTitolo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grbAddPubblicazione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariabile)).BeginInit();
            this.grbViewCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCatalog)).BeginInit();
            this.grbCercaPerTitolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiPubblicazioneToolStripMenuItem,
            this.visualizzaCatalogoToolStripMenuItem,
            this.cercaPerTitoloToolStripMenuItem,
            this.calcolaPrezzoMedioToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aggiungiPubblicazioneToolStripMenuItem
            // 
            this.aggiungiPubblicazioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rivistaToolStripMenuItem,
            this.libroToolStripMenuItem});
            this.aggiungiPubblicazioneToolStripMenuItem.Name = "aggiungiPubblicazioneToolStripMenuItem";
            this.aggiungiPubblicazioneToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.aggiungiPubblicazioneToolStripMenuItem.Text = "Aggiungi Pubblicazione";
            // 
            // rivistaToolStripMenuItem
            // 
            this.rivistaToolStripMenuItem.Name = "rivistaToolStripMenuItem";
            this.rivistaToolStripMenuItem.Size = new System.Drawing.Size(215, 44);
            this.rivistaToolStripMenuItem.Text = "Rivista";
            this.rivistaToolStripMenuItem.Click += new System.EventHandler(this.rivistaToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(215, 44);
            this.libroToolStripMenuItem.Text = "Libro";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // visualizzaCatalogoToolStripMenuItem
            // 
            this.visualizzaCatalogoToolStripMenuItem.Name = "visualizzaCatalogoToolStripMenuItem";
            this.visualizzaCatalogoToolStripMenuItem.Size = new System.Drawing.Size(239, 38);
            this.visualizzaCatalogoToolStripMenuItem.Text = "Visualizza Catalogo";
            this.visualizzaCatalogoToolStripMenuItem.Click += new System.EventHandler(this.visualizzaCatalogoToolStripMenuItem_Click);
            // 
            // cercaPerTitoloToolStripMenuItem
            // 
            this.cercaPerTitoloToolStripMenuItem.Name = "cercaPerTitoloToolStripMenuItem";
            this.cercaPerTitoloToolStripMenuItem.Size = new System.Drawing.Size(198, 38);
            this.cercaPerTitoloToolStripMenuItem.Text = "Cerca per titolo";
            this.cercaPerTitoloToolStripMenuItem.Click += new System.EventHandler(this.cercaPerTitoloToolStripMenuItem_Click);
            // 
            // calcolaPrezzoMedioToolStripMenuItem
            // 
            this.calcolaPrezzoMedioToolStripMenuItem.Name = "calcolaPrezzoMedioToolStripMenuItem";
            this.calcolaPrezzoMedioToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.calcolaPrezzoMedioToolStripMenuItem.Text = "Calcola Prezzo Medio";
            this.calcolaPrezzoMedioToolStripMenuItem.Click += new System.EventHandler(this.calcolaPrezzoMedioToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // grbAddPubblicazione
            // 
            this.grbAddPubblicazione.Controls.Add(this.nudPrezzo);
            this.grbAddPubblicazione.Controls.Add(this.btnAddPubblicazione);
            this.grbAddPubblicazione.Controls.Add(this.nudVariabile);
            this.grbAddPubblicazione.Controls.Add(this.lblVariabile);
            this.grbAddPubblicazione.Controls.Add(this.label4);
            this.grbAddPubblicazione.Controls.Add(this.label3);
            this.grbAddPubblicazione.Controls.Add(this.Titolo);
            this.grbAddPubblicazione.Controls.Add(this.txtAddAutore);
            this.grbAddPubblicazione.Controls.Add(this.txtAddTitolo);
            this.grbAddPubblicazione.Location = new System.Drawing.Point(26, 54);
            this.grbAddPubblicazione.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbAddPubblicazione.Name = "grbAddPubblicazione";
            this.grbAddPubblicazione.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbAddPubblicazione.Size = new System.Drawing.Size(652, 358);
            this.grbAddPubblicazione.TabIndex = 2;
            this.grbAddPubblicazione.TabStop = false;
            this.grbAddPubblicazione.Text = "Aggiungi Pubblicazione";
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.DecimalPlaces = 2;
            this.nudPrezzo.Location = new System.Drawing.Point(14, 144);
            this.nudPrezzo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(350, 31);
            this.nudPrezzo.TabIndex = 10;
            // 
            // btnAddPubblicazione
            // 
            this.btnAddPubblicazione.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPubblicazione.Location = new System.Drawing.Point(114, 279);
            this.btnAddPubblicazione.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddPubblicazione.Name = "btnAddPubblicazione";
            this.btnAddPubblicazione.Size = new System.Drawing.Size(372, 44);
            this.btnAddPubblicazione.TabIndex = 9;
            this.btnAddPubblicazione.Text = "Aggiungi Pubblicazione";
            this.btnAddPubblicazione.UseVisualStyleBackColor = false;
            this.btnAddPubblicazione.Click += new System.EventHandler(this.btnAddPubblicazione_Click);
            // 
            // nudVariabile
            // 
            this.nudVariabile.Location = new System.Drawing.Point(14, 194);
            this.nudVariabile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudVariabile.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudVariabile.Name = "nudVariabile";
            this.nudVariabile.Size = new System.Drawing.Size(350, 31);
            this.nudVariabile.TabIndex = 8;
            this.nudVariabile.Visible = false;
            // 
            // lblVariabile
            // 
            this.lblVariabile.AutoSize = true;
            this.lblVariabile.Location = new System.Drawing.Point(548, 198);
            this.lblVariabile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVariabile.Name = "lblVariabile";
            this.lblVariabile.Size = new System.Drawing.Size(0, 25);
            this.lblVariabile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autore";
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Location = new System.Drawing.Point(548, 44);
            this.Titolo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(65, 25);
            this.Titolo.TabIndex = 4;
            this.Titolo.Text = "Titolo";
            // 
            // txtAddAutore
            // 
            this.txtAddAutore.Location = new System.Drawing.Point(14, 88);
            this.txtAddAutore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddAutore.Name = "txtAddAutore";
            this.txtAddAutore.Size = new System.Drawing.Size(346, 31);
            this.txtAddAutore.TabIndex = 1;
            // 
            // txtAddTitolo
            // 
            this.txtAddTitolo.Location = new System.Drawing.Point(14, 38);
            this.txtAddTitolo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddTitolo.Name = "txtAddTitolo";
            this.txtAddTitolo.Size = new System.Drawing.Size(346, 31);
            this.txtAddTitolo.TabIndex = 0;
            // 
            // grbViewCatalog
            // 
            this.grbViewCatalog.Controls.Add(this.dgvViewCatalog);
            this.grbViewCatalog.Location = new System.Drawing.Point(714, 54);
            this.grbViewCatalog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbViewCatalog.Name = "grbViewCatalog";
            this.grbViewCatalog.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbViewCatalog.Size = new System.Drawing.Size(862, 788);
            this.grbViewCatalog.TabIndex = 3;
            this.grbViewCatalog.TabStop = false;
            this.grbViewCatalog.Text = "Visualizza Catalogo";
            // 
            // dgvViewCatalog
            // 
            this.dgvViewCatalog.AllowUserToAddRows = false;
            this.dgvViewCatalog.AllowUserToDeleteRows = false;
            this.dgvViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCatalog.Location = new System.Drawing.Point(12, 38);
            this.dgvViewCatalog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvViewCatalog.Name = "dgvViewCatalog";
            this.dgvViewCatalog.RowHeadersWidth = 82;
            this.dgvViewCatalog.Size = new System.Drawing.Size(838, 738);
            this.dgvViewCatalog.TabIndex = 0;
            // 
            // grbCercaPerTitolo
            // 
            this.grbCercaPerTitolo.Controls.Add(this.btnCercaPerTitolo);
            this.grbCercaPerTitolo.Controls.Add(this.label6);
            this.grbCercaPerTitolo.Controls.Add(this.txtCercaPerTitolo);
            this.grbCercaPerTitolo.Location = new System.Drawing.Point(26, 425);
            this.grbCercaPerTitolo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbCercaPerTitolo.Name = "grbCercaPerTitolo";
            this.grbCercaPerTitolo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbCercaPerTitolo.Size = new System.Drawing.Size(652, 417);
            this.grbCercaPerTitolo.TabIndex = 4;
            this.grbCercaPerTitolo.TabStop = false;
            this.grbCercaPerTitolo.Text = "Cerca Per Titolo";
            // 
            // btnCercaPerTitolo
            // 
            this.btnCercaPerTitolo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCercaPerTitolo.Location = new System.Drawing.Point(114, 208);
            this.btnCercaPerTitolo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCercaPerTitolo.Name = "btnCercaPerTitolo";
            this.btnCercaPerTitolo.Size = new System.Drawing.Size(372, 98);
            this.btnCercaPerTitolo.TabIndex = 10;
            this.btnCercaPerTitolo.Text = "Cerca";
            this.btnCercaPerTitolo.UseVisualStyleBackColor = false;
            this.btnCercaPerTitolo.Click += new System.EventHandler(this.btnCercaPerTitolo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Titolo:";
            // 
            // txtCercaPerTitolo
            // 
            this.txtCercaPerTitolo.Location = new System.Drawing.Point(114, 94);
            this.txtCercaPerTitolo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCercaPerTitolo.Name = "txtCercaPerTitolo";
            this.txtCercaPerTitolo.Size = new System.Drawing.Size(368, 31);
            this.txtCercaPerTitolo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.grbCercaPerTitolo);
            this.Controls.Add(this.grbViewCatalog);
            this.Controls.Add(this.grbAddPubblicazione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Gestione Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbAddPubblicazione.ResumeLayout(false);
            this.grbAddPubblicazione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariabile)).EndInit();
            this.grbViewCatalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCatalog)).EndInit();
            this.grbCercaPerTitolo.ResumeLayout(false);
            this.grbCercaPerTitolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aggiungiPubblicazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rivistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercaPerTitoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcolaPrezzoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbAddPubblicazione;
        private System.Windows.Forms.Button btnAddPubblicazione;
        private System.Windows.Forms.NumericUpDown nudVariabile;
        private System.Windows.Forms.Label lblVariabile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.TextBox txtAddAutore;
        private System.Windows.Forms.TextBox txtAddTitolo;
        private System.Windows.Forms.GroupBox grbViewCatalog;
        private System.Windows.Forms.DataGridView dgvViewCatalog;
        private System.Windows.Forms.GroupBox grbCercaPerTitolo;
        private System.Windows.Forms.Button btnCercaPerTitolo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCercaPerTitolo;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
    }
}

