using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoOOPeRegex
{
    internal class Libro : Materiale
    {
        private string autore;

        public Libro(string titolo, string codice, string autore) : base(titolo, codice)
        {
            this.Autore = autore;
        }

        public string Autore { get => autore; set => autore = value; }

        public override string Descrivi()
        {
            return $"{base.Descrivi()}; Autore: {this.autore}";
        }
    }
}
