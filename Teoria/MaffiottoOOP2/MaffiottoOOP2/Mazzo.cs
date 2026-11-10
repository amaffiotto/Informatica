using System;
using System.Collections.Generic;
using System.Text;

namespace MaffiottoOOP2
{
    public class Mazzo
    {
        Dictionary<int, char> mazzo = new Dictionary<int, char>();

        public Mazzo()
        {
            CreaMazzo();
        }

        private void CreaMazzo()
        {
            for (int i = 0; i < 40; i++)
            {
                Carta tmp = new Carta();
                int valore;
                char seme;
                tmp.Lettura(out valore);
                tmp.Lettura(out seme);

                tmp.Valore = valore;
                tmp.Seme = seme;

                while (mazzo.ContainsKey(valore) || mazzo.ContainsValue(seme))
                {
                    tmp.Lettura(out valore);
                    tmp.Lettura(out seme);

                    tmp.Valore = valore;
                    tmp.Seme = seme;
                }
            }
        }

        public Carta Estrai()
        {
            Carta tmp = new Carta();
            int valore;
            char seme;
            tmp.Lettura(out valore);
            tmp.Lettura(out seme);

            tmp.Valore = valore;
            tmp.Seme = seme;

            return tmp;

        }
    }
}
