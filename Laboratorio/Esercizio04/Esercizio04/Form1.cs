using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //========================
        //    STRUCT STUDENTE
        //========================
        
        public struct studente
        {
            // Definire cratteristiche

            public int nMatr;

            public string cognome;

            public string nome;

            public DateTime dataDN;

            public string classe; //3A, 4B...

            public string spec; // INF, MEC, ELT

            // Costruttore
            public studente(int nM, string co, string no, DateTime dN, string cl, string sp)
            {
                nMatr = nM;
                cognome = co;
                nome = no;
                dataDN = dN;
                classe = cl;
                spec = sp;
            }

            // Pulizia dati studente
            public void Clear()
            {
                nMatr = 0;
                cognome = string.Empty;
                nome = string.Empty;
                dataDN = DateTime.MinValue;
                classe = string.Empty;
                spec = string.Empty;
            }

            // Calcolo età studente 
            public int CaclolaEta()
            {
                int eta;

                eta = DateTime.Now.Year - dataDN.Year;

                return eta;
            }

            // Dati studente 
            public string GetStudente()
            {
                return $"N Matricola = {nMatr} | Cognome = {cognome} | Nome = {nome} | Data di nascita =  {dataDN.ToString(@"dd/MM/yyyy")} | Classe = {classe} | Specializzazione = {spec}"; 
            }

            // Dati studente per salvare su file

            public override string ToString()
            {
                return nMatr.ToString() + ";";
            }
        }
    }
}
