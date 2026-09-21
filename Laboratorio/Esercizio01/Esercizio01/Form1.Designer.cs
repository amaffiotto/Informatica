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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picVallauri = new System.Windows.Forms.PictureBox();
            this.btnDuplica = new System.Windows.Forms.Button();
            this.btnDuplica2 = new System.Windows.Forms.Button();
            this.btnDuplica3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVallauri)).BeginInit();
            this.SuspendLayout();
            // 
            // picVallauri
            // 
            this.picVallauri.Image = ((System.Drawing.Image)(resources.GetObject("picVallauri.Image")));
            this.picVallauri.Location = new System.Drawing.Point(13, 13);
            this.picVallauri.Name = "picVallauri";
            this.picVallauri.Size = new System.Drawing.Size(200, 190);
            this.picVallauri.TabIndex = 0;
            this.picVallauri.TabStop = false;
            // 
            // btnDuplica
            // 
            this.btnDuplica.Location = new System.Drawing.Point(298, 13);
            this.btnDuplica.Name = "btnDuplica";
            this.btnDuplica.Size = new System.Drawing.Size(99, 43);
            this.btnDuplica.TabIndex = 1;
            this.btnDuplica.Text = "Duplica";
            this.btnDuplica.UseVisualStyleBackColor = true;
            this.btnDuplica.Click += new System.EventHandler(this.btnDuplica_Click);
            // 
            // btnDuplica2
            // 
            this.btnDuplica2.Location = new System.Drawing.Point(403, 12);
            this.btnDuplica2.Name = "btnDuplica2";
            this.btnDuplica2.Size = new System.Drawing.Size(99, 45);
            this.btnDuplica2.TabIndex = 2;
            this.btnDuplica2.Text = "Duplica 2";
            this.btnDuplica2.UseVisualStyleBackColor = true;
            this.btnDuplica2.Click += new System.EventHandler(this.btnDuplica2_Click);
            // 
            // btnDuplica3
            // 
            this.btnDuplica3.Location = new System.Drawing.Point(508, 15);
            this.btnDuplica3.Name = "btnDuplica3";
            this.btnDuplica3.Size = new System.Drawing.Size(99, 41);
            this.btnDuplica3.TabIndex = 3;
            this.btnDuplica3.Text = "Aggiungi";
            this.btnDuplica3.UseVisualStyleBackColor = true;
            this.btnDuplica3.Click += new System.EventHandler(this.btnDuplica3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDuplica3);
            this.Controls.Add(this.btnDuplica2);
            this.Controls.Add(this.btnDuplica);
            this.Controls.Add(this.picVallauri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picVallauri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picVallauri;
        private System.Windows.Forms.Button btnDuplica;
        private System.Windows.Forms.Button btnDuplica2;
        private System.Windows.Forms.Button btnDuplica3;
    }
}

