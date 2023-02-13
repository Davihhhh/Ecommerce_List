using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Alimentari : Prodotto
    {
        //variabili
        private string[] _ingredienti;
        private string _scadenza;

        private DateTime DataScadenza;
        private DateTime Data = DateTime.Today;
        private int MaxIngredienti = 10;
        
        

        public string[] Ingredienti
        {
            get { if (_ingredienti == null || _ingredienti.Length > MaxIngredienti || _ingredienti.Length < 1)
                    throw new Exception("Ingrediente/i invalido/i");
                else
                    return _ingredienti; }
            private set { _ingredienti = value; }
        }
        public string Scadenza
        {
            get
            {                
                return _scadenza;
            }
            private set
            {
                if (value == null || value.Length < 6 || value.Length > 10)
                    throw new Exception("Scadenza invalida");
                _scadenza = value;
            }
        }
        //costruttori
        public Alimentari(string nome, string descrizione, string produttore, double prezzo, string[] ingredienti, string scadenza): base (nome, descrizione, produttore, prezzo)
        {
            _ingredienti = ingredienti;
            try
            {
                DataScadenza = DateTime.Parse(scadenza);
            }
            catch { Exception exp; throw new Exception("Scadenza invalida"); }            
            Scadenza = scadenza;
            Sconto = 50;
        }


        //funzioni
        public override double getPrezzoScontato()
        {
            double scontato = 0.00;
            int g = Giorni_alla_scadenza();
            if (g < 0)
                throw new Exception("Prodotto già scaduto");
            else if (g >= 0 && g <= 7)
                scontato = base.getPrezzoScontato();
            else
                return Prezzo;
            return scontato;
        }

        private int Giorni_alla_scadenza()
        {
            int giorni;
            giorni = DateTime.Compare(DataScadenza, Data);
            return giorni;
        }      
    }
}
