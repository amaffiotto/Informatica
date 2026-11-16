using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoOOP_Regex
{
    internal class DVD : Materiale
    {
        private double durata;

        public DVD(string titolo, string codice, double dur) : base(titolo, codice)
        {
            this.Durata = dur;
        }

        public override string Descrivi()
        {
            return $"{base.Descrivi()}; Durata: {this.durata} minuti";
        }
        public double Durata { get => durata; set => durata = value; }
    }
}
