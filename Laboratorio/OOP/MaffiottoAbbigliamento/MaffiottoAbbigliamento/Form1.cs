using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaffiottoAbbigliamento
{
    public partial class Form1 : Form
    {
        List<clsMaglie> maglie = new List<clsMaglie>();
        List<clsPantaloni> pantaloni = new List<clsPantaloni>();
        List<clsBorse> borse = new List<clsBorse>();
        List<clsScarpe> scarpe = new List<clsScarpe>();
        List<clsGiacche> giacche = new List<clsGiacche>();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
