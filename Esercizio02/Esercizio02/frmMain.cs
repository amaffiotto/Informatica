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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void caso1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            Program.s1 =  "sono S1 e mi chiamo debora";
            MessageBox.Show($"S1 = \"{Program.s1}\"");

            f2.ShowDialog();

            MessageBox.Show($"S1 = \"{Program.s1}\"");
        }

        private void caso2VariabilePublicForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            MessageBox.Show($"frmMain - s2 = \"{f3.s2}\"");

            f3.s2 = "Sono la meat di tommy e sono il bidet";
            MessageBox.Show($"frmMain - s2 = \"{f3.s2}\"");

            f3.ShowDialog();

            f3.Cambia("POV: Tommaso el caballo loco distrugge ragazza 2011 di seconda meccanica");
            MessageBox.Show($"frmMain - s2 = \"{f3.s2}\"");

            f3.ShowDialog();
            MessageBox.Show($"frmMain - s2 = \"{f3.s2}\"");
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
