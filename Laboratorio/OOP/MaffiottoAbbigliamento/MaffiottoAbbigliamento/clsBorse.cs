using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoAbbigliamento
{
    internal class clsBorse : clsIndumento
    {
        private string tipologia; //tracolla, zainetto, marsupio, pochette
        private string taglia; //PICCOLA, MEDIA, GRANDE
        private string stagione; //invernale, estiva

        public clsBorse() : base()
        {
            Tipologia = "";
            Taglia = "";
            Stagione = "";
        }
        public clsBorse(string m, double p, string c, string mat, string g, string tip, string tag, string stag) : base(m, p, c, mat, g)
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
