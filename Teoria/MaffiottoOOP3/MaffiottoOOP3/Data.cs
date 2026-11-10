using System;
using System.Collections.Generic;
using System.Text;

namespace MaffiottoOOP3
{
    public class Data
    {
        private int giorno;
        private int mese;
        private int anno;

        public Data()
        {
            giorno = 1;
            mese = 1;
            anno = 1900;
        }

        public Data(int giorno, int mese, int anno)
        {
            this.giorno = giorno;
            this.mese = mese;
            this.anno = anno;
        }

        public virtual string ToString()
        {
            return $"{giorno:D2}/{mese:D2}/{anno}";
        }

        public virtual bool Bisestile()
        {
            return (anno % 4 == 0 && (anno % 100 != 0 || anno % 400 == 0));
        }

        public virtual void Leggi(int giorno, int mese, int anno)
        {
            this.giorno = giorno;
            this.mese = mese;
            this.anno = anno;
        }

        public virtual void Scrivi(out int giorno, out int mese, out int anno)
        {
            giorno = this.giorno;
            mese = this.mese;
            anno = this.anno;
        }

        public virtual void Domani()
        {
            DateTime dt = new DateTime(anno, mese, giorno).AddDays(1);
            giorno = dt.Day;
            mese = dt.Month;
            anno = dt.Year;
        }

        public virtual void Ieri()
        {
            DateTime dt = new DateTime(anno, mese, giorno).AddDays(-1);
            giorno = dt.Day;
            mese = dt.Month;
            anno = dt.Year;
        }

        public virtual string Giorno()
        {
            return new DateTime(anno, mese, giorno).ToString("dddd");
        }
    }
}
