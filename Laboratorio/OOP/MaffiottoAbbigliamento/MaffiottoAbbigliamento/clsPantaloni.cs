using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoAbbigliamento
{
    internal class clsPantaloni : clsIndumento
    {
        private string tipo; // JEANS, felpati, leggings, classici
        private uint taglia; // 44, 46, 48, 50, 52, 54, 56, 58, 60
        private string lunghezza; // lunghi, corti, pinocchietti
        private string vestibilità; // slim skinny

        clsPantaloni() : base()
        {
            Tipo = "";
            Taglia = 0;
            Lunghezza = "";
            Vestibilità = "";
        }
        public clsPantaloni(string m, double p, string c, string mat, string g, string tip, uint tag, string lun, string ves) : base(m, p, c, mat, g)
        {
            Tipo = tip;
            Taglia = tag;
            Lunghezza = lun;
            Vestibilità = ves;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public uint Taglia { get => taglia; set => taglia = value; }
        public string Lunghezza { get => lunghezza; set => lunghezza = value; }
        public string Vestibilità { get => vestibilità; set => vestibilità = value; }

        public override string IndToString()
        {
            return $"{base.IndToString()};{Tipo};{Taglia};{Lunghezza};{Vestibilità}";
        }
    }
}
