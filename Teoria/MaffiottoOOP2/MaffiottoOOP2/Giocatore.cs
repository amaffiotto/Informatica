using System;
using System.Collections.Generic;
using System.Text;

namespace MaffiottoOOP2
{
    public class Giocatore
    {
        private string nome;
        private Mano mano;
        private Mano prese;

        public Giocatore(string nome)
        {
            this.nome = nome;
            this.mano = new Mano();
            this.prese = new Mano();
        }

        public List<Carta> Lettura()
        {
            return mano.Lettura();
        }

        public List<Carta> Prese()
        {
            return prese.Lettura();
        }

        public Carta Gioca(int indice)
        {
            return mano.Gioca(indice);
        }
    }
}
