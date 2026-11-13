using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoAbbigliamento
{
    internal class clsGiacche : clsIndumento
    {
        private string tipologia; // impermeabile, piumino, giacca, kway, giubbotto, cappotto
        private string taglia; // XS/S/M/L/XL/XXL/XXXL
        private string stagione; // invernale, estivo, primaverile

        public clsGiacche() : base()
        {
            Tipologia = "";
            Taglia = "";
            Stagione = "";
        }
        public clsGiacche(string m, double p, string c, string mat, string g, string tip, string tag, string stag) : base(m, p, c, mat, g)
        {
            Tipologia = tip;
            Taglia = tag;
            Stagione = stag;
        }

        public string Tipologia { get => tipologia; set => tipologia = value; }
        public string Taglia { get => taglia; set => taglia = value; }
        public string Stagione { get => stagione; set => stagione = value; }

        public override string IndToString()
        {
            return $"{base.IndToString()};{Tipologia};{Taglia};{Stagione}";
        }
    }
}
