using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoOOPeRegex
{
    internal class Rivista : Materiale
    {
        private uint numeroEdizione;

        public Rivista(string titolo, string codice, uint nEdizione) : base(titolo, codice)
        {
            this.NumeroEdizione = nEdizione;
        }
        public override string Descrivi()
        {
            return $"{base.Descrivi()}; Numero Edizione: {this.numeroEdizione}";
        }
        public uint NumeroEdizione { get => numeroEdizione; set => numeroEdizione = value; }
    }
}
