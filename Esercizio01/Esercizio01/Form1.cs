using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio01
{
    public partial class Form1 : Form
    {
        int dif = 20;
        int prgImmagine = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {
            PictureBox nuovaIMG = new PictureBox();

            nuovaIMG.Size = new Size(picVallauri.Width, picVallauri.Height);

            this.Controls.Add(nuovaIMG);

            nuovaIMG.Image = picVallauri.Image;

            nuovaIMG.Name = $"picDuplica{++prgImmagine}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + dif, picVallauri.Location.Y + dif);

            dif += 20;
        }

        private void btnDuplica2_Click(object sender, EventArgs e)
        {
            PictureBox nuovaIMG = new PictureBox();
            nuovaIMG.Size = new Size(200, 100);

            this.Controls.Add(nuovaIMG);

            Bitmap bmp = new Bitmap(200, 100);
            Graphics bmpGraphics = Graphics.FromImage(bmp);

            bmpGraphics.FillRectangle(Brushes.Blue, 0, 0, 200, 100);
            nuovaIMG.Image = bmp;

            nuovaIMG.Name = $"picDuplica2{++prgImmagine}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + dif, picVallauri.Location.Y + dif);

            dif += 50;
        }

        private void btnDuplica3_Click(object sender, EventArgs e)
        {
            TextBox nuovoTxt = new TextBox();

            nuovoTxt.Size = new Size(200, 20);
            nuovoTxt.Name = "txtInput";

            this.Controls.Add(nuovoTxt);

            nuovoTxt.Location = new Point(btnDuplica.Location.X, btnDuplica.Location.Y + btnDuplica.Size.Height + 25);

            Button nuovoBTN = new Button()
            {
                Size = new Size(btnDuplica3.Size.Width, btnDuplica3.Size.Height),
                Name = "btnVisualizza",
                Location = new Point(btnDuplica3.Location.X, btnDuplica3.Location.Y + btnDuplica3.Size.Height + 25),
                Text = "Visualizza"
            };

            // Evento Click
            nuovoBTN.Click += btnVisualizza_Click;

            this.Controls.Add(nuovoBTN);

            btnDuplica3.Enabled = false;

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;

            MessageBox.Show($"Evento creato da [{control.Name}] : {Controls["txtInput"].Text}");
        }
    }
}
