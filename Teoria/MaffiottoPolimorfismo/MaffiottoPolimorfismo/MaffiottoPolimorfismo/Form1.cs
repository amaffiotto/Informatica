using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaffiottoPolimorfismo
{
    public partial class Form1 : Form
    {
        List<Uccello> Uccelli = new List<Uccello>();
        Corvo c1 = new Corvo();
        Oca o1 = new Oca();
        Uccello u1 = new Uccello();
        Corvo c2 = new Corvo();
        Oca o2 = new Oca();
        Corvo c3 = new Corvo();
        

        public Form1()
        {
            InitializeComponent();
            Uccelli.Add(c1);
            Uccelli.Add(o1);
            Uccelli.Add(u1);
            Uccelli.Add(c2);
            Uccelli.Add(o2);
            Uccelli.Add(c3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, Uccelli.Count);
            Uccelli[index].Verso();
        }
    }
}
