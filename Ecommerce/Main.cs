using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        Prodotto prova1 = new Elettronico("nome", "modello", "descrzione", "produttore", 20.0);
        Carrello cart = new Carrello();

        private void Main_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string str = "20, 10, fds2000";
            try 
            { 
                DateTime compare = DateTime.Parse(str);
                textBox.Text = compare.ToString();
            }
            catch(Exception) { MessageBox.Show("data invalida"); }
;            
            //textBox.Text = prova1.getPrezzoScontato().ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSvuota_Click(object sender, EventArgs e)
        {
            if (cart.Lista.Count <= 0)
                MessageBox.Show("Carrello già vuoto");
            else
                cart.Svuota();                      
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            if (cart.Lista.Count <= 0)
                MessageBox.Show("Carrello già vuoto");
            else
                try
                {
                    int num = Convert.ToInt32(textBoxCancella.Text);
                    cart.RimuoviProdottoConPosizione(num);
                }
                catch { MessageBox.Show("Inserisci una posizione prodotto valida (numero)"); }

        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string produttore = textBoxProduttore.Text;
            string descrizione = textBoxDescrizione.Text;
            double prezzo = 0;
            //Prodotto p;           
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(produttore) || string.IsNullOrEmpty(descrizione))
            {
                MessageBox.Show("Inserisci tutti i valori richiesti");
            }
            else
            {
                try { prezzo = Convert.ToDouble(textBoxPrezzo.Text); } catch { MessageBox.Show("Prezzo inadeguato"); return; }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
