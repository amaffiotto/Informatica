using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoBilblioteca
{
    public class Rivista : Pubblicazione
    {
        private uint nEdizione;
        public uint NEdizione { get => nEdizione; set => nEdizione = value; }

        public Rivista() : base()
        {
            this.NEdizione = 0;
        }
        public Rivista(string t, string a, double p, uint ne) : base(t, a, p)
        {
            this.NEdizione = ne;
        }

        public new string VisualizzaInfo()
        {
            return $"{base.VisualizzaInfo()} Edizione: {nEdizione}";
        }

    }
}
