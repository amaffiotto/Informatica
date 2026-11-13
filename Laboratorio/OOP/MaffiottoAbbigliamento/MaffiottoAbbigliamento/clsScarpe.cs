using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoAbbigliamento
{
    internal class clsScarpe : clsIndumento
    {
        private string tipologia; //sandali, da ginnastica, mocassini, stivali, ciabatte
        private uint taglia; // 18....50
        private string apertura; //lacci, velcro, zip, aperte
        private string suola; //cuoio, gomma, plastica, legno

        public clsScarpe() : base()
        {
            Tipologia = "";
            Taglia = 0;
            Apertura = "";
            Suola = "";
        }
        public clsScarpe(string m, double p, string c, string mat, string g, string tip, uint tag, string ap, string s) : base(m, p, c, mat, g)
        {
            Tipologia = tip;
            Taglia = tag;
            Apertura = ap;
            Suola = s;
        }

        public string Tipologia { get => tipologia; set => tipologia = value; }
        public uint Taglia { get => taglia; set => taglia = value; }
        public string Apertura { get => apertura; set => apertura = value; }
        public string Suola { get => suola; set => suola = value; }

        public override string IndToString()
        {
            return $"{base.IndToString()};{Tipologia};{Taglia};{Apertura};{Suola}";
        }   
    }
}
