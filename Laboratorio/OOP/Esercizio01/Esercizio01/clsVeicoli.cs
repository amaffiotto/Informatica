using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01
{
    public class clsVeicoli
    {
        private string pMarca;
        private string pColore;
        private string pModello;
        private uint pCilindrata;
        private DateTime pDataImmatricolazione;

        // Costruttore
        public clsVeicoli()
        {
            pMarca = string.Empty;
            pColore = string.Empty;
            pModello = string.Empty;
            pCilindrata = 0;
            pDataImmatricolazione = DateTime.MinValue; 
        }

        public string Marca { get => pMarca; set => pMarca = value; }
        public string Colore { get => pColore; set => pColore = value; }
        public string Modello { get => pModello; set => pModello = value; }
        public uint Cilindrata { get => pCilindrata; set => pCilindrata = value; }
        public DateTime DataImmatricolazione { get => pDataImmatricolazione; set => pDataImmatricolazione = value; }

        // Visualizzo info veicolo
        public string VisualizzaVeicolo()
        {
            return $@"Veicolo:
                - Marca: {pMarca}
                - Modello: {pModello}
                - Colore: {pColore}
                - Cilindrata: {pCilindrata.ToString()}cc
                - Data Immatricolazione {DataImmatricolazione.ToString("dd/MM/yyyy")}";
        }

        /// <summary>
        /// Calcolo età del veicolo
        /// </summary>
        /// <returns>Numero di anni di età del veicolo</returns>
        public uint EtaVeicolo()
        {
            return Convert.ToUInt16(DateTime.Now.Year - pDataImmatricolazione.Year);
        }

        /// <summary>
        /// Calcola il prezzo del bollo
        /// </summary>
        /// <returns>prezzo in euro del bollo</returns>
        public double CalcolaBollo()
        {
            double bollo = 0.0;
            
            if(EtaVeicolo() > 5)
            {
                if(pCilindrata <= 1000)
                {
                    bollo = pCilindrata * 0.08;
                }
                else if(pCilindrata <= 1999)
                {
                    bollo = pCilindrata * 0.11;
                }
                else
                {
                    bollo = pCilindrata * 0.15;
                }
            }

            return bollo;
        }

        /// <summary>
        /// Calcola il consumo medio km/l in base alla cilindrata
        /// </summary>
        /// <returns>Numero di km percorsi con un litro di benzina</returns>
        public double CalcolaConsumoMedio()
        {
            if(pCilindrata <= 1500)
            {
                return 18;
            }
            else if(pCilindrata <= 2500)
            {
                return 13.8;
            }
            else
            {
                return 9.3;
            }
        }

        public double CalcolaCostoViaggio(int kmPercorsi, double prezzoCarburante)
        {
            double kmPerLitro = CalcolaConsumoMedio();
            double nLitri = kmPercorsi / kmPerLitro;
            return nLitri * prezzoCarburante;
        }

    }
}
