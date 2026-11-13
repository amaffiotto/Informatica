namespace MaffiottoAbbigliamento
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpgMaglie = new System.Windows.Forms.TabPage();
            this.tabpgPantaloni = new System.Windows.Forms.TabPage();
            this.pabpgScarpe = new System.Windows.Forms.TabPage();
            this.tabpgGiacche = new System.Windows.Forms.TabPage();
            this.tabpgBorse = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaglieMarca = new System.Windows.Forms.TextBox();
            this.nudMagliePrezzo = new System.Windows.Forms.NumericUpDown();
            this.txtMaglieColore = new System.Windows.Forms.TextBox();
            this.txtMaglieMateriale = new System.Windows.Forms.TextBox();
            this.txtMaglieGenere = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMaglieTipo = new System.Windows.Forms.ComboBox();
            this.cmbMaglieTaglia = new System.Windows.Forms.ComboBox();
            this.cmbMaglieManica = new System.Windows.Forms.ComboBox();
            this.cmbMaglieApertura = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabpgMaglie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagliePrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpgMaglie);
            this.tabControl.Controls.Add(this.tabpgPantaloni);
            this.tabControl.Controls.Add(this.pabpgScarpe);
            this.tabControl.Controls.Add(this.tabpgGiacche);
            this.tabControl.Controls.Add(this.tabpgBorse);
            this.tabControl.Location = new System.Drawing.Point(-2, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(816, 334);
            this.tabControl.TabIndex = 0;
            // 
            // tabpgMaglie
            // 
            this.tabpgMaglie.Controls.Add(this.button2);
            this.tabpgMaglie.Controls.Add(this.btnAggiungi);
            this.tabpgMaglie.Controls.Add(this.dataGridView1);
            this.tabpgMaglie.Controls.Add(this.cmbMaglieApertura);
            this.tabpgMaglie.Controls.Add(this.cmbMaglieManica);
            this.tabpgMaglie.Controls.Add(this.cmbMaglieTaglia);
            this.tabpgMaglie.Controls.Add(this.cmbMaglieTipo);
            this.tabpgMaglie.Controls.Add(this.label7);
            this.tabpgMaglie.Controls.Add(this.label8);
            this.tabpgMaglie.Controls.Add(this.label9);
            this.tabpgMaglie.Controls.Add(this.label10);
            this.tabpgMaglie.Controls.Add(this.txtMaglieGenere);
            this.tabpgMaglie.Controls.Add(this.txtMaglieMateriale);
            this.tabpgMaglie.Controls.Add(this.txtMaglieColore);
            this.tabpgMaglie.Controls.Add(this.nudMagliePrezzo);
            this.tabpgMaglie.Controls.Add(this.txtMaglieMarca);
            this.tabpgMaglie.Controls.Add(this.label5);
            this.tabpgMaglie.Controls.Add(this.label4);
            this.tabpgMaglie.Controls.Add(this.label3);
            this.tabpgMaglie.Controls.Add(this.label2);
            this.tabpgMaglie.Controls.Add(this.label1);
            this.tabpgMaglie.Location = new System.Drawing.Point(4, 22);
            this.tabpgMaglie.Name = "tabpgMaglie";
            this.tabpgMaglie.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgMaglie.Size = new System.Drawing.Size(808, 308);
            this.tabpgMaglie.TabIndex = 0;
            this.tabpgMaglie.Text = "Maglie";
            this.tabpgMaglie.UseVisualStyleBackColor = true;
            // 
            // tabpgPantaloni
            // 
            this.tabpgPantaloni.Location = new System.Drawing.Point(4, 22);
            this.tabpgPantaloni.Name = "tabpgPantaloni";
            this.tabpgPantaloni.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgPantaloni.Size = new System.Drawing.Size(808, 308);
            this.tabpgPantaloni.TabIndex = 1;
            this.tabpgPantaloni.Text = "Pantaloni";
            this.tabpgPantaloni.UseVisualStyleBackColor = true;
            // 
            // pabpgScarpe
            // 
            this.pabpgScarpe.Location = new System.Drawing.Point(4, 22);
            this.pabpgScarpe.Name = "pabpgScarpe";
            this.pabpgScarpe.Padding = new System.Windows.Forms.Padding(3);
            this.pabpgScarpe.Size = new System.Drawing.Size(793, 318);
            this.pabpgScarpe.TabIndex = 2;
            this.pabpgScarpe.Text = "Scarpe";
            this.pabpgScarpe.UseVisualStyleBackColor = true;
            // 
            // tabpgGiacche
            // 
            this.tabpgGiacche.Location = new System.Drawing.Point(4, 22);
            this.tabpgGiacche.Name = "tabpgGiacche";
            this.tabpgGiacche.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgGiacche.Size = new System.Drawing.Size(793, 318);
            this.tabpgGiacche.TabIndex = 3;
            this.tabpgGiacche.Text = "giacche";
            this.tabpgGiacche.UseVisualStyleBackColor = true;
            // 
            // tabpgBorse
            // 
            this.tabpgBorse.Location = new System.Drawing.Point(4, 22);
            this.tabpgBorse.Name = "tabpgBorse";
            this.tabpgBorse.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgBorse.Size = new System.Drawing.Size(793, 318);
            this.tabpgBorse.TabIndex = 4;
            this.tabpgBorse.Text = "Borse";
            this.tabpgBorse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Materiale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genere";
            // 
            // txtMaglieMarca
            // 
            this.txtMaglieMarca.Location = new System.Drawing.Point(87, 16);
            this.txtMaglieMarca.Name = "txtMaglieMarca";
            this.txtMaglieMarca.Size = new System.Drawing.Size(120, 20);
            this.txtMaglieMarca.TabIndex = 5;
            // 
            // nudMagliePrezzo
            // 
            this.nudMagliePrezzo.DecimalPlaces = 2;
            this.nudMagliePrezzo.Location = new System.Drawing.Point(87, 42);
            this.nudMagliePrezzo.Name = "nudMagliePrezzo";
            this.nudMagliePrezzo.Size = new System.Drawing.Size(120, 20);
            this.nudMagliePrezzo.TabIndex = 6;
            // 
            // txtMaglieColore
            // 
            this.txtMaglieColore.Location = new System.Drawing.Point(87, 68);
            this.txtMaglieColore.Name = "txtMaglieColore";
            this.txtMaglieColore.Size = new System.Drawing.Size(120, 20);
            this.txtMaglieColore.TabIndex = 7;
            // 
            // txtMaglieMateriale
            // 
            this.txtMaglieMateriale.Location = new System.Drawing.Point(87, 94);
            this.txtMaglieMateriale.Name = "txtMaglieMateriale";
            this.txtMaglieMateriale.Size = new System.Drawing.Size(121, 20);
            this.txtMaglieMateriale.TabIndex = 8;
            // 
            // txtMaglieGenere
            // 
            this.txtMaglieGenere.FormattingEnabled = true;
            this.txtMaglieGenere.Items.AddRange(new object[] {
            "Uomo",
            "Donna",
            "Bambino",
            "Bambina"});
            this.txtMaglieGenere.Location = new System.Drawing.Point(87, 120);
            this.txtMaglieGenere.Name = "txtMaglieGenere";
            this.txtMaglieGenere.Size = new System.Drawing.Size(121, 21);
            this.txtMaglieGenere.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Apertura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Manica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Taglia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tipo";
            // 
            // cmbMaglieTipo
            // 
            this.cmbMaglieTipo.FormattingEnabled = true;
            this.cmbMaglieTipo.Items.AddRange(new object[] {
            "felpa",
            "t-shirt",
            "polo",
            "canotta"});
            this.cmbMaglieTipo.Location = new System.Drawing.Point(86, 146);
            this.cmbMaglieTipo.Name = "cmbMaglieTipo";
            this.cmbMaglieTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbMaglieTipo.TabIndex = 18;
            // 
            // cmbMaglieTaglia
            // 
            this.cmbMaglieTaglia.FormattingEnabled = true;
            this.cmbMaglieTaglia.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cmbMaglieTaglia.Location = new System.Drawing.Point(87, 171);
            this.cmbMaglieTaglia.Name = "cmbMaglieTaglia";
            this.cmbMaglieTaglia.Size = new System.Drawing.Size(121, 21);
            this.cmbMaglieTaglia.TabIndex = 19;
            // 
            // cmbMaglieManica
            // 
            this.cmbMaglieManica.FormattingEnabled = true;
            this.cmbMaglieManica.Items.AddRange(new object[] {
            "Lunga",
            "Corta",
            "MezzaManica",
            "Smanicata"});
            this.cmbMaglieManica.Location = new System.Drawing.Point(87, 195);
            this.cmbMaglieManica.Name = "cmbMaglieManica";
            this.cmbMaglieManica.Size = new System.Drawing.Size(121, 21);
            this.cmbMaglieManica.TabIndex = 20;
            // 
            // cmbMaglieApertura
            // 
            this.cmbMaglieApertura.FormattingEnabled = true;
            this.cmbMaglieApertura.Items.AddRange(new object[] {
            "Zip",
            "Bottoni",
            "Velcro",
            "Senza"});
            this.cmbMaglieApertura.Location = new System.Drawing.Point(86, 221);
            this.cmbMaglieApertura.Name = "cmbMaglieApertura";
            this.cmbMaglieApertura.Size = new System.Drawing.Size(121, 21);
            this.cmbMaglieApertura.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 272);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAggiungi.Location = new System.Drawing.Point(31, 248);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(84, 40);
            this.btnAggiungi.TabIndex = 23;
            this.btnAggiungi.Text = "Aggiungi Maglia";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(121, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Rimuovi Maglia";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 332);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestione Abbigliamento";
            this.tabControl.ResumeLayout(false);
            this.tabpgMaglie.ResumeLayout(false);
            this.tabpgMaglie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagliePrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpgMaglie;
        private System.Windows.Forms.TabPage tabpgPantaloni;
        private System.Windows.Forms.TabPage pabpgScarpe;
        private System.Windows.Forms.TabPage tabpgGiacche;
        private System.Windows.Forms.TabPage tabpgBorse;
        private System.Windows.Forms.ComboBox txtMaglieGenere;
        private System.Windows.Forms.TextBox txtMaglieMateriale;
        private System.Windows.Forms.TextBox txtMaglieColore;
        private System.Windows.Forms.NumericUpDown nudMagliePrezzo;
        private System.Windows.Forms.TextBox txtMaglieMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaglieApertura;
        private System.Windows.Forms.ComboBox cmbMaglieManica;
        private System.Windows.Forms.ComboBox cmbMaglieTaglia;
        private System.Windows.Forms.ComboBox cmbMaglieTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

