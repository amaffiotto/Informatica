using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MaffiottoBilblioteca
{
    public partial class Form1 : Form
    {
        bool isBook;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisableAllUiElements()
        {
            grbAddPubblicazione.Enabled = false;
            grbCercaPerTitolo.Enabled = false;
            grbViewCatalog.Enabled = false;
        }

        public void ClearAllUiElements()
        {
            txtAddAutore.Text = "";
            txtAddTitolo.Text = "";
            txtCercaPerTitolo.Text = "";
            nudPrezzo.Value = 0;
            nudVariabile.Value = 0;
        }
        private bool CheckPubInformation()
        {
            if (txtAddAutore.Text == string.Empty)
            {
                MessageBox.Show("Campo Autore Vuoto");
                txtAddAutore.Focus();
                return false;
            }
            if (txtAddTitolo.Text == string.Empty)
            {
                MessageBox.Show("Campo Titolo Vuoto");
                txtAddTitolo.Focus();
                return false;
            }
            if (nudPrezzo.Value == 0 || nudPrezzo.Value > 100)
            {
                MessageBox.Show("Campo Prezzo non può essere 0 o maggiore di 100");
                nudPrezzo.Focus();
                return false;
            }
            if (nudVariabile.Value == 0)
            {
                MessageBox.Show("Questo campo non può essere ZERO!!!");
                nudVariabile.Focus();
                return false;
            }

            return true;
        }

        // =============== Metodi Utente ^^^^ Metodi Generati VVVVV ===============
        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAllUiElements();
            ClearAllUiElements();

            if(File.Exists("Libreria.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Pubblicazione>), new Type[] { typeof(Libro), typeof(Rivista) });
                using(StreamReader sr = new StreamReader("Libreria.xml"))
                {
                    Libreria.Pubblicazioni = (List<Pubblicazione>)ser.Deserialize(sr);
                }
            }
        }


        private void rivistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAllUiElements();
            ClearAllUiElements();
            grbAddPubblicazione.Enabled = true;
            lblVariabile.Text = "Numero Edizione";
            nudVariabile.Visible = true;
            isBook = false;
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAllUiElements();
            ClearAllUiElements();
            grbAddPubblicazione.Enabled = true;
            lblVariabile.Text = "Numero Pagine";
            nudVariabile.Visible = true;
            isBook = true;
        }

        private void btnAddPubblicazione_Click(object sender, EventArgs e)
        {
            if (CheckPubInformation())
            {
                if (isBook)
                {
                    Libro toAdd = new Libro(
                        txtAddTitolo.Text,
                        txtAddAutore.Text,
                        Convert.ToDouble(nudPrezzo.Value),
                        Convert.ToUInt32(nudVariabile.Value)
                        );
                    Libreria.AggiungiPubblicazione(toAdd);
                }
                else
                {
                    Rivista toAdd = new Rivista(
                        txtAddTitolo.Text,
                        txtAddAutore.Text,
                        Convert.ToDouble(nudPrezzo.Value),
                        Convert.ToUInt32(nudVariabile.Value)
                        );
                    Libreria.AggiungiPubblicazione(toAdd);
                }
                MessageBox.Show("Pubblicazione aggiunta con successo");

            }

        }

        private void visualizzaCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAllUiElements();
            ClearAllUiElements();
            grbViewCatalog.Enabled = true;
            Libreria.VisualizzaCatalogo(ref dgvViewCatalog);
        }

        private void cercaPerTitoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAllUiElements();
            ClearAllUiElements();
            grbCercaPerTitolo.Enabled = true;
        }

        private void btnCercaPerTitolo_Click(object sender, EventArgs e)
        {
            if(txtCercaPerTitolo.Text == string.Empty)
            {
                txtCercaPerTitolo.Focus();
                MessageBox.Show("Campo titolo NON può essere vuoto");
            }
            else
            {
                Pubblicazione searched = Libreria.CercaPerTitolo(txtCercaPerTitolo.Text);
                if(searched == null)
                {
                    MessageBox.Show("Pubblicazione NON trovata");
                }
                else
                {
                    MessageBox.Show($"{searched.VisualizzaInfo()}","Pubblicazione trovata");
                }
            }
        }

        private void calcolaPrezzoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllUiElements();
            DisableAllUiElements();
            MessageBox.Show($"Prezzo medio libreria: {Libreria.CalcolaPrezzoMedio()}");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllUiElements();
            this.Close();
        }
    }
}
