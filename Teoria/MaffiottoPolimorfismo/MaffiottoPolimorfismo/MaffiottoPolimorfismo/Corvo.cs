using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaffiottoPolimorfismo
{
    public class Corvo : Uccello
    {
        public override void Verso()
        {
            MessageBox.Show("cra cra", "Corvo");
        }
    }
}
