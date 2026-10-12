namespace Esercizio01
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
            this.grbGestioneVeicoli = new System.Windows.Forms.GroupBox();
            this.btnCreaVeicolo = new System.Windows.Forms.Button();
            this.grbGestioneVeicoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGestioneVeicoli
            // 
            this.grbGestioneVeicoli.Controls.Add(this.btnCreaVeicolo);
            this.grbGestioneVeicoli.Location = new System.Drawing.Point(12, 12);
            this.grbGestioneVeicoli.Name = "grbGestioneVeicoli";
            this.grbGestioneVeicoli.Size = new System.Drawing.Size(400, 237);
            this.grbGestioneVeicoli.TabIndex = 0;
            this.grbGestioneVeicoli.TabStop = false;
            this.grbGestioneVeicoli.Text = "Gestione Veicoli";
            // 
            // btnCreaVeicolo
            // 
            this.btnCreaVeicolo.Location = new System.Drawing.Point(6, 19);
            this.btnCreaVeicolo.Name = "btnCreaVeicolo";
            this.btnCreaVeicolo.Size = new System.Drawing.Size(75, 23);
            this.btnCreaVeicolo.TabIndex = 0;
            this.btnCreaVeicolo.Text = "Crea Veicolo";
            this.btnCreaVeicolo.UseVisualStyleBackColor = true;
            this.btnCreaVeicolo.Click += new System.EventHandler(this.btnCreaVeicolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbGestioneVeicoli);
            this.Name = "Form1";
            this.Text = "OOP Esercizio 1 - Gestione veicoli";
            this.grbGestioneVeicoli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGestioneVeicoli;
        private System.Windows.Forms.Button btnCreaVeicolo;
    }
}

