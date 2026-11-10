using System;
using System.Collections.Generic;
using System.Text;

namespace MaffiottoOOP2
{
    public class Carta
    {
        private Random rnd = new Random();
        private int _valore;
        private char _seme;

        public int Valore { get => _valore; set => _valore = value; }
        public char Seme { get => _seme; set => _seme = value; }

        public int Lettura(out int valore)
        {
            valore = rnd.Next(1, 11);
            return valore;
        }

        public char Lettura(out char seme)
        {
            seme = ' ';
            switch (rnd.Next(4))
            {
                case 0:
                    seme = 'A';
                    break;
                case 1:
                    seme = 'B';
                    break;
                case 2:
                    seme = 'C';
                    break;
                case 3:
                    seme = 'D';
                    break;
                default:
                    break;
            }

            return seme;
        }
    }
}
