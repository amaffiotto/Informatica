using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblVariabile.Text = Program.s1;
            Program.s1 = "SONO S1 SONO NINA LUPU/DEBORA ed amo il pentagono";
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
