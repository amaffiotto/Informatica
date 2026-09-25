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
                return nMatr.ToString() + ";"
                    + cognome + ";"
                    + nome + ";" 
                    + dataDN.Day.ToString() + "/" 
                    + dataDN.Month.ToString() + "/"
                    + dataDN.Year.ToString() + ";" 
                    + classe + ";" 
                    + spec + ";";
            }
        }

        public studente[]  classe4a = new studente[30];

        public string[] int_studente = { "N. MATRICOLA", "COGNOME", "NOME", "DATA DI NASCITA", "CLASSE", "SPECIALIZZAZIONE" };

        private void Form1_Load(object sender, EventArgs e)
        {
            //=== Inserisci Studenti === 

            grbStudente.Enabled = false;
            dtpDataDiNascita.Value = DateTime.Now;

            // Carico Combo Specializzazioni

            cmbSpecializzazione.Items.Add("INF");
            cmbSpecializzazione.Items.Add("MEC");
            cmbSpecializzazione.Items.Add("ELT");
            cmbSpecializzazione.Items.Add("LSSA");
            cmbSpecializzazione.Items.Add("ECO");
            cmbSpecializzazione.Items.Add("TUR");

            cmbClasse.SelectedIndex = -1;
            cmbSpecializzazione.SelectedIndex = -1;
        }
        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void inserisciStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbStudente.Enabled = true;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            studente stuAus = new studente();
            int pos;

            // Controllo dati input
            if (CheckDatiStudente())
            {
                pos = PosizioneStudente();
                if(pos != -1)
                {
                    stuAus.nMatr = Convert.ToInt32(nudMatricola.Value);
                    stuAus.cognome = txtCognome.Text;
                    stuAus.nome = txtNome.Text;
                    stuAus.dataDN = dtpDataDiNascita.Value;
                    stuAus.classe = cmbClasse.Text;
                    stuAus.spec = cmbSpecializzazione.Text;

                    classe4a[pos] = stuAus;

                    MessageBox.Show("Studente inserito con successo");
                }
                else
                {
                    MessageBox.Show("La classe è completa !!!");
                }
            }
        }

        

        // ===========================================================================
        //                              GESTITI DA NOI
        // ===========================================================================

        public bool CheckDatiStudente()
        {
            bool errore = false;

            if (CheckNumeroDiMatricola())
            {
                // Numero di matricola
                nudMatricola.Focus();
                MessageBox.Show("N Matricola già presente nella classe");
                errore = true;
            }
            else if(txtCognome.Text == string.Empty)
            {
                // Cognome
                txtCognome.Focus();
                MessageBox.Show("Cognome non è stato inserito");
                errore = true;
            }
            else if(txtNome.Text == string.Empty)
            {
                // Nome
                txtNome.Focus();
                MessageBox.Show("Nome non è stato inserito");
                errore = true;
            }
            else if(cmbClasse.Text == string.Empty)
            {
                // Classe
                cmbClasse.Focus();
                MessageBox.Show("Classe non è stata selezionata");
                errore = true;
            }
            else if(cmbSpecializzazione.Text == string.Empty)
            {
                // Specializzazione
                cmbSpecializzazione.Focus();
                MessageBox.Show("Specializzazione non è stata selezionata");
                errore = true;
            }

            return !errore;
        }

        public bool CheckNumeroDiMatricola()
        {
            bool errore = false;

            for(int i = 0; i < classe4a.Length; i++)
            {
                if (classe4a[i].nMatr == Convert.ToInt32(nudMatricola.Value))
                {
                    errore = true;
                    break;
                }
            }

            return errore;
        }

        public int PosizioneStudente()
        {
            int pos = -1;

            for(int i = 0; i < classe4a.Length; i++)
            {
                if (classe4a[i].nMatr == 0)
                {
                    pos = i;
                    break;
                }
            }

            return pos;
        }
    }
}
