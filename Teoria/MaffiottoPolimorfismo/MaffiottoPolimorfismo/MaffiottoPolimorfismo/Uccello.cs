using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaffiottoPolimorfismo
{
    public class Uccello
    {
        public virtual void Verso()
        {
            MessageBox.Show("cip cip", "Uccello");
        }
    }
}
