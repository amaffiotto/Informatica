namespace Esercizio02
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caso1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caso2VariabilePublicForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caso1ToolStripMenuItem,
            this.caso2VariabilePublicForm2ToolStripMenuItem,
            this.chiudiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caso1ToolStripMenuItem
            // 
            this.caso1ToolStripMenuItem.Name = "caso1ToolStripMenuItem";
            this.caso1ToolStripMenuItem.Size = new System.Drawing.Size(182, 20);
            this.caso1ToolStripMenuItem.Text = "Caso 1 - Variabile globale static";
            this.caso1ToolStripMenuItem.Click += new System.EventHandler(this.caso1ToolStripMenuItem_Click);
            // 
            // caso2VariabilePublicForm2ToolStripMenuItem
            // 
            this.caso2VariabilePublicForm2ToolStripMenuItem.Name = "caso2VariabilePublicForm2ToolStripMenuItem";
            this.caso2VariabilePublicForm2ToolStripMenuItem.Size = new System.Drawing.Size(185, 20);
            this.caso2VariabilePublicForm2ToolStripMenuItem.Text = "Caso 2 - Variabile public Form 3";
            this.caso2VariabilePublicForm2ToolStripMenuItem.Click += new System.EventHandler(this.caso2VariabilePublicForm2ToolStripMenuItem_Click);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.chiudiToolStripMenuItem.Text = "Esci";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Esercizio 2 - Passaggio parametri tra Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caso1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caso2VariabilePublicForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
    }
}

