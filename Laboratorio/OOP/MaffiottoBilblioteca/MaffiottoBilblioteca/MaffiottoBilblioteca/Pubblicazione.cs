using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoBilblioteca
{
    public class Pubblicazione : clsAstratta
    {
        private string titolo;
        private string autore;
        private double prezzo;

        public string Titolo { get => titolo; set => titolo = value; }
        public string Autore { get => autore; set => autore = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }

        public Pubblicazione()
        {
            this.Titolo = "";
            this.Autore = "";
            this.Prezzo = 0;
        }
        public Pubblicazione(string t, string a, double p) 
        { 
            this.Titolo = t;
            this.Autore = a;
            this.Prezzo = p;
        }

        public new string VisualizzaInfo()
        {
            return $"{this.titolo} di {this.autore} prezzo: {this.prezzo}$";
        }
    }
}
