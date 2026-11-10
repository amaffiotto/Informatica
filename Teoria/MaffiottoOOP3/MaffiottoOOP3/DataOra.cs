using System;
using System.Collections.Generic;
using System.Text;

namespace MaffiottoOOP3
{
    public class Data_Ora : Data
    {
        private int ore;
        private int minuti;
        private int secondi;

        public Data_Ora() : base()
        {
            ore = 0;
            minuti = 0;
            secondi = 0;
        }

        public Data_Ora(int giorno, int mese, int anno) : base(giorno, mese, anno)
        {
            ore = 0;
            minuti = 0;
            secondi = 0;
        }

        public Data_Ora(int giorno, int mese, int anno, int ore, int minuti, int secondi)
            : base(giorno, mese, anno)
        {
            this.ore = ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }

        public override string ToString()
        {
            return base.ToString() + $" {ore:D2}:{minuti:D2}:{secondi:D2}";
        }

        public void Leggi(int ore, int minuti, int secondi)
        {
            this.ore = ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }

        public void Scrivi(out int ore, out int minuti, out int secondi)
        {
            ore = this.ore;
            minuti = this.minuti;
            secondi = this.secondi;
        }
    }
}
