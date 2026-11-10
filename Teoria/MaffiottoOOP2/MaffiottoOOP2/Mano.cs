using System;
using System.Collections.Generic;
using System.Text;

namespace MaffiottoOOP2
{
    public class Mano
    {
        private List<Carta> carte;

        public Mano()
        {
            carte = new List<Carta>();
        }

        public void Aggiungi(Carta c)
        {
            carte.Add(c);
        }

        public List<Carta> Lettura()
        {
            return carte;
        }

        public Carta Gioca(int indice)
        {
            if (indice >= 0 && indice < carte.Count)
            {
                Carta c = carte[indice];
                carte.RemoveAt(indice);
                return c;
            }
            return null;
        }
    }
}
