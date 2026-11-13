using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaffiottoAbbigliamento
{
    public class clsIndumento : clsAstratta
    {
        private string marca;
        private double prezzo;
        private string colore;
        private string materiale;
        private string genere; // UOMO/DONNA/BAMBINO/BAMBINA

        public clsIndumento()
        {
            Marca = "";
            Prezzo = 0;
            Colore = "";
            Materiale = "";
            Genere = "";
        }
        public clsIndumento(string m, double p, string c, string mat, string g)
        {
            Marca = m;
            Prezzo = p;
            Colore = c;
            Materiale = m;
            Genere = g;
        }

        public string Marca { get => marca; set => marca = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public string Colore { get => colore; set => colore = value; }
        public string Materiale { get => materiale; set => materiale = value; }
        public string Genere { get => genere; set => genere = value; }

        public override string IndToString()
        {
            return $"{Marca};{Prezzo};{Colore};{Materiale};{Genere}";
        }

        public void LoadToDGV(ref DataGridView dgv, List<clsIndumento> lista)
        {
            dgv.DataSource = lista;
        }
    }
}
