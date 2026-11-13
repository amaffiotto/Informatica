using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoBilblioteca
{
    public class Libro : Pubblicazione
    {
        private uint nPagine;
        public uint NPagine { get => nPagine; set => nPagine = value; }

        public Libro() : base()
        {
            this.NPagine = 0;
        }
        public Libro(string t, string a, double p, uint np) : base(t, a, p)
        {
            this.NPagine = np;
        }

        public new string VisualizzaInfo()
        {
            return $"{base.VisualizzaInfo()} {nPagine} Pagine";
        }

    }
}
