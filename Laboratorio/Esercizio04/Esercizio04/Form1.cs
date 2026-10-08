using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Esercizio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**********************/
        /* Struttura Studente */
        /**********************/

        public struct Studente
        {
            //Definisco le caratteristiche
            public int nMatricola;
            public string Nome;
            public string Cognome;
            public DateTime dataNascita;
            public string classe;
            public string spec;

            //Costruttore
            public Studente(int nM, string nome, string cognome, DateTime dNascita, string cl, string sp)
            {
                nMatricola = nM;
                Nome = nome;
                Cognome = cognome;
                dataNascita = dNascita;
                classe = cl;
                spec = sp;
            }

            //Pulizia dati studente

            public void Clear()
            {
                nMatricola = 0;
                Nome = string.Empty;
                Cognome = string.Empty;
                dataNascita = DateTime.MinValue;
                classe = string.Empty;
                spec = string.Empty;
            }

            // Calcolo Età Studente

            public int calcolaEta()
            {
                return DateTime.Now.Year - dataNascita.Year;
            }

            // Dati dello studente

            public string getStudente()
            {
                return $"N° Matricola:{nMatricola}\nCognome: {Cognome}\nNome: {Nome}\nData Nascita: {dataNascita.ToString(@"dd\MM\yyyy")}\nClasse: {classe}\nSpecializzazione:{spec}";
            }

            //Dati studente per salvare sul File

            public override string ToString()
            {
                return $"{nMatricola.ToString()} | {Cognome} | {Nome} | {dataNascita.Day.ToString()}/{dataNascita.Month.ToString()}/{dataNascita.Year.ToString()} | {classe} | {spec}";
            }

        }


        public Studente[] classe4A = new Studente[30];
        public string[] int_Studente = { "N.MATRICOLA", "COGNOME", "NOME", "DATA NASCITA", "CLASSE", "SPECIALIZZAZIONE" };
        private void Form1_Load(object sender, EventArgs e)
        {
            grbStudente.Enabled = false;
            grbClasse.Enabled = false;
            grbRicerca.Enabled = false;
            grbStudente.Enabled = false;

            ClearDatiStudente();
            dtpDataNascita.Value = DateTime.Now;

            //Carico combo specializzazioni
            cmbSpecializzazione.Items.Add("INF");
            cmbSpecializzazione.Items.Add("MEC");
            cmbSpecializzazione.Items.Add("ELT");
            cmbSpecializzazione.Items.Add("LSSA");
            cmbSpecializzazione.Items.Add("ECO");
            cmbSpecializzazione.Items.Add("TUR");

            cmbClasse.SelectedIndex = -1;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserisciStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbStudente.Enabled = true;
            grbClasse.Enabled = false;
            grbRicerca.Enabled = false;
            grbStudente.Enabled = false;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Studente studAus = new Studente();


            int pos;

            //Controllo dati Input
            if (!CheckDatiStudente())
            {
                pos = PosizioneStudente();

                if (pos != -1)
                {
                    studAus.nMatricola = Convert.ToInt32(nudMatricola.Value);
                    studAus.Cognome = txtCognome.Text;
                    studAus.Nome = txtNome.Text;
                    studAus.dataNascita = dtpDataNascita.Value;
                    studAus.classe = cmbClasse.Text;
                    studAus.spec = cmbSpecializzazione.Text;
                    classe4A[pos] = studAus;

                    MessageBox.Show("Studente inserito con successo !!!");
                }
                else
                {
                    MessageBox.Show("La classe è piena");
                }
            }

            ClearInserimento();
            grbStudente.Enabled = false;

        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            ClearInserimento();
            grbStudente.Enabled = false;
        }

        private void salvaSuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerificaStudenti())
            {
                this.Cursor = Cursors.WaitCursor;

                //Imposto il file di salvataggio
                //TextWriter

                StreamWriter sw = new StreamWriter("Classe4A.txt");
                for (int i = 0; i < classe4A.Length; i++)
                {
                    if (classe4A[i].nMatricola != 0)
                    {
                        sw.WriteLine(classe4A[i].ToString());
                    }
                }

                this.Cursor = Cursors.Default;
                MessageBox.Show("Classe salvata con successo sul file");
            }
            else
            {
                MessageBox.Show("La classe non contiene studenti");
            }
        }
        private void caricaDaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool leggiDati = false;
            string s;
            string[] vDati = new string[6];
            int pos = -1;

            if (VerificaStudenti())
            {
                if (MessageBox.Show("La classe contiene già degli studenti", "Caricamento Studenti da File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InizializzaClasse();
                    leggiDati = true;
                }
            }
            else
            {
                leggiDati = true;
            }

            if (leggiDati)
            {
                using (StreamReader sr = new StreamReader("Classe4A.txt"))
                {
                    while (sr.EndOfStream)
                    {
                        s = sr.ReadLine();
                        vDati = s.Split(';');
                        pos++;
                        classe4A[pos].nMatricola = Convert.ToInt32(vDati[0]);
                        classe4A[pos].Cognome = vDati[1];
                        classe4A[pos].Nome = vDati[2];
                        classe4A[pos].dataNascita = Convert.ToDateTime(vDati[3]);
                        classe4A[pos].classe = vDati[4];
                        classe4A[pos].spec = vDati[5];
                    }
                }

                MessageBox.Show("La classe è stata recuperata da file con successo");

                VisualizzaClasse();
            }
        }
        private void visualizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizzaClasse();
        }

        private void ricercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbRicerca.Enabled = true;
            grbStudente.Enabled = false;
            grbClasse.Enabled = false;

            ClearInserimento();
        }
        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string tipoR = string.Empty;
            bool trovato = false;

            // Tipo di ricerca
            if(txtCognome.Text != string.Empty &&
                txtNome.Text != string.Empty)
            {
                tipoR = "CN"; 
            }
            else
            {
                tipoR = "NM";
            }

            // Ricerco eventuale studente

            for(int i = 0; i < classe4A.Length; i++)
            {
                // Ricerca per matricola
                if(tipoR == "NM")
                {
                    if (classe4A[i].nMatricola == nudMatricola.Value)
                    {
                        trovato = true;
                        VisualizzaDatiStudente(i);
                        break;
                    }
                }
                else
                {
                    // Ricerca per cognome nome
                    if (string.Compare(classe4A[i].Cognome, txtRicercaCognome.Text) == 0 &&
                        string.Compare(classe4A[i].Nome, txtRicercaNome.Text) == 0)
                    {
                        trovato = true;
                        break;
                    }
                }
            }

            if (!trovato)
            {
                MessageBox.Show($"Lo studente NON è stato trovato!!!");
            }
        }


        // ====================================================================================================
        private void VisualizzaDatiStudente(int i)
        {
            grbStudente.Enabled = true;
            lblMatricola.Text = classe4A[i].nMatricola.ToString();
            lblCognome.Text = classe4A[i].Cognome;
            lblNome.Text = classe4A[i].Nome;
            lblDDN.Text = classe4A[i].dataNascita.ToString(@"dd,MM,yyyy");
            lblClasse.Text = classe4A[i].classe;
            lblSpec.Text = classe4A[i].spec;
        }
        public void VisualizzaClasse()
        {
            grbClasse.Enabled = true;
            grbRicerca.Enabled = false;
            grbStudente.Enabled = false;

            ClearInserimento();

            // Impostazione della DGV
            dgvClasse.Rows.Clear();
            dgvClasse.ReadOnly = true;
            dgvClasse.ColumnCount = 6;
            dgvClasse.RowHeadersVisible = false;
            dgvClasse.AllowUserToAddRows = false;
            dgvClasse.AllowUserToResizeColumns = false;
            dgvClasse.AllowUserToResizeRows = false;
            dgvClasse.AllowUserToResizeColumns = false;

            dgvClasse.ClearSelection();

            if (VerificaStudenti())
            {
                for(int i = 0; i < int_Studente.Length; i++)
                {
                    dgvClasse.Columns[i].HeaderText = int_Studente[i];
                }
                
                // Carico gli studenti 
                
                for(int i = 0; i < classe4A.Length; i++)
                {
                    if (classe4A[i].nMatricola != 0)
                    {
                        dgvClasse.Rows.Add(
                            classe4A[i].nMatricola.ToString(),
                            classe4A[i].Cognome,
                            classe4A[i].Nome,
                            classe4A[i].dataNascita.ToString(@"DD/MM/aaaa"),
                            classe4A[i].classe,
                            classe4A[i].spec
                            );
                    }

                    dgvClasse.AutoResizeColumns();
                }
            }
            

        }
        public bool CheckDatiStudente()
        {
            bool errore = false;

            // Controllo Numero Matricola
            if (CheckNMatricola())
            {
                nudMatricola.Focus();
                MessageBox.Show("N° Matricola già presente nella classe");
                errore = true;
            }
            else if (txtCognome.Text == string.Empty)
            {
                //Cognome
                txtCognome.Focus();
                MessageBox.Show("Cognome non inserito");
                errore = true;
            }
            else if (txtNome.Text == string.Empty)
            {
                //Nome
                txtNome.Focus();
                MessageBox.Show("Nome non inserito");
                errore = true;
            }
            else if (cmbClasse.Text == string.Empty)
            {
                cmbClasse.Focus();
                MessageBox.Show("Classe non selezionata");
                errore = true;
            }
            else if (cmbSpecializzazione.Text == string.Empty)
            {
                cmbSpecializzazione.Focus();
                MessageBox.Show("Specializzazione non selezionata");
                errore = true;
            }

            return errore;
        }

        public bool CheckNMatricola()
        {
            bool errore = false;

            for (int i = 0; i < classe4A.Length; i++)
            {
                if (classe4A[i].nMatricola == Convert.ToInt32(nudMatricola.Value))
                {
                    errore = true;
                    break;
                }
            }

            return errore;
        }
        private int PosizioneStudente()
        {
            int pos = -1;

            for (int i = 0; i < classe4A.Length; i++)
            {
                if (classe4A[i].nMatricola == 0)
                {
                    pos = i;
                    break;
                }
            }

            return pos;
        }
        private void ClearInserimento()
        {
            nudMatricola.Value = 1;
            txtCognome.Text = string.Empty;
            txtNome.Text = string.Empty;
            dtpDataNascita.Value = DateTime.Now;
            cmbClasse.SelectedIndex = -1;
            cmbSpecializzazione.SelectedIndex = -1;

        }


        private bool VerificaStudenti()
        {
            //int cont = 0;

            for (int i = 0; i < classe4A.Length; i++)
            {
                if (classe4A[i].nMatricola != 0)
                    return true;
                //{
                //    cont++;
                //    break;
                //}
            }

            return false;
        }
        private void InizializzaClasse()
        {
            for (int i = 0; i < classe4A.Length; i++)
            {
                classe4A[i].Clear();
            }
        }
        
        public void ClearDatiStudente()
        {
            lblClasse.Text = string.Empty;
            lblNome.Text = string.Empty;
            lblCognome.Text = string.Empty;
            lblDDN.Text = string.Empty;
            lblSpec.Text = string.Empty;
            lblMatricola.Text = string.Empty;
        }
    }
}