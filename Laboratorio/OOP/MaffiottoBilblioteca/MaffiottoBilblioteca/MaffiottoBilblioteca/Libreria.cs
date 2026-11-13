using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace MaffiottoBilblioteca
{
    public static class Libreria
    {
        static public List<Pubblicazione> Pubblicazioni = new List<Pubblicazione>();

        static public void AggiungiPubblicazione(Pubblicazione p)
        {
            Pubblicazioni.Add(p);
            XmlSerializer ser = new XmlSerializer(typeof(List<Pubblicazione>), new Type[] { typeof(Libro), typeof(Rivista) });
            using(StreamWriter sw = new StreamWriter("Libreria.xml"))
            {
                ser.Serialize(sw, Pubblicazioni);
            }
        }

        static public void VisualizzaCatalogo(ref DataGridView dgv)
        {
            dgv.DataSource = Pubblicazioni;
        }

        static public Pubblicazione CercaPerTitolo(string titolo)
        {
            return Pubblicazioni.Find(p => (p.Titolo).ToLower() == titolo.ToLower());
        }

        static public double CalcolaPrezzoMedio()
        {
            double avgPrice = 0;


            foreach(Pubblicazione pub in Pubblicazioni)
            {
                avgPrice += pub.Prezzo;
            }

            return avgPrice /= Pubblicazioni.Count;
        }
    }
}
