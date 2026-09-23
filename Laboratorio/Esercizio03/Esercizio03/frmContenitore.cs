using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio03
{
    public partial class frmContenitore : Form
    {
        public frmContenitore()
        {
            InitializeComponent();
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.MdiParent = this;

            f2.Show();
        }

        private void apriForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.MdiParent = this;

            f3.Show();
        }

        private void apriForm4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.MdiParent = this;

            f4.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
