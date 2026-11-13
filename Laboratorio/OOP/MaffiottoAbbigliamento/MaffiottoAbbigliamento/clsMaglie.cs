using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoAbbigliamento
{
    internal class clsMaglie : clsIndumento
    {
        private string tipo;
        private string taglia; // XS/S/M/L/XL/XXL/XXXL
        private string manica; // CORTA/LUNGA/MEZZAMANICA/SMANICATA
        private string apertura; //Zip, bottoni, velcro, senza

        public clsMaglie() : base()
        {
            Tipo = "";
            Taglia = "";
            Manica = "";
            Apertura = "";
        }
        public clsMaglie(string m, double p, string c, string mat, string g, string tip, string tag, string man, string ap) : base(m, p, c, mat, g)
        {
            Tipo = tip;
            Taglia = tag;
            Manica = man;
            Apertura = ap;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Taglia { get => taglia; set => taglia = value; }
        public string Manica { get => manica; set => manica = value; }
        public string Apertura { get => apertura; set => apertura = value; }

        public override string IndToString()
        {
            return $"{base.IndToString()};{Tipo};{Taglia};{Manica};{Apertura}";
        }
    }
}
