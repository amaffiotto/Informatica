using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaffiottoOOP_Regex
{
    public class Materiale
    {
        private string titolo;
        private string codice;

        public Materiale(string titolo, string codice)
        {
            this.titolo = titolo;
            this.codice = GeneraCodiceRandom();
        }

        internal string GeneraCodiceRandom()
        {
            Random random = new Random();
            string codice = "";
            for(int i = 0; i < 2; i++)
            {
                char randomLetter = (char)('A' + random.Next(0, 26));
                codice += randomLetter;
            }
            int nNumCodice = random.Next(3, 6);
            for(int i = 0; i < nNumCodice; i++)
            {
                int randomNumber = random.Next(0, 10);
                codice += randomNumber.ToString();
            }
            return codice;
        }

        public virtual string Descrivi()
        {
            return $"Titolo: {this.Titolo}; Codice: {this.Codice}";
        }

        public string Titolo { get => titolo; set => titolo = value; }
        public string Codice { get => codice; set => codice = value; }
    }
}
