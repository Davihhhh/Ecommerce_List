using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Carrello
    {
        //variabili
        private string _id;       
        private List<Prodotto> _lista;
      
        private Random rnd = new Random();

        //properties
        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }               
        public List<Prodotto> Lista
        {
            get { return _lista; }
            private set { _lista = value; }
        }

        //costruttori        
        public Carrello()
        {
            Id = GeneraId();            
            Lista = new List<Prodotto>();           
        }        


        //funzioni pubbliche
        public void AggiungiProdotto(Prodotto p, int quantità)
        {
            if (p == null || quantità < 1)
            {
                throw new Exception("aggiunta invalida");
            }
            else
            {
                for (int a = 0; a < quantità; a++)
                    Lista.Add(p);
            }
        }
        public Prodotto RimuoviProdotto(Prodotto p, int quantità)
        {
            if (Lista.Count <= 0)
            {
                throw new Exception("Carrello vuoto o invalido");
            }
            else
            {
                int pos = RicercaProdotto(p);
                if (pos < 0)
                {
                    throw new Exception("Prodotto non presente");
                }
                else
                {
                    int quantità_effettiva = RicercaQuantitàProdotto(p);
                    if (quantità_effettiva >= quantità)
                    { }
                    else
                        quantità = quantità_effettiva;
                    RicompattazioneConQuantità(pos, quantità);
                    return p;
                }
            }
        }
        public void RimuoviProdottoConPosizione(int posizione)
        {
           
            if (Lista.Count <= 0)
            {
                throw new Exception("Carrello vuoto o invalido");
            }
            else
            {
                RicompattazioneConQuantità(posizione, 1);
            }
        }
        public void RimuoviTuttiProdottiUguali(Prodotto p)
        {
            if (Lista.Count <= 0)
            {
                throw new Exception("Carrello vuoto o invalido");
            }
            else
            {
                int pos = RicercaProdotto(p);
                if (pos < 0)
                {
                    throw new Exception("Prodotto non presente");
                }
                else
                {
                    int quantità = RicercaQuantitàProdotto(p);
                    RicompattazioneConQuantità(pos, quantità);
                }
            }
        }
        public List<Prodotto> Svuota()
        {
            List<Prodotto> value = Lista;
            Lista = new List<Prodotto>();
            return value;
        }
        public List<Prodotto> GetProdotti()
        {
            return Lista;
        }

        public double getPrezzo()
        {
            if (Lista == null || Lista.Count <= 0)
                throw new Exception("Lista invalida");
            else
            {
                double totale = 0;
                foreach (Prodotto p in Lista)
                {
                    totale = p.Prezzo + totale;
                }
                return totale;
            }
        }
        public double getPrezzoScontato()
        {
            if (Lista == null || Lista.Count <= 0)
                throw new Exception("Lista invalida");
            else
            {
                double totale = 0;
                foreach (Prodotto p in Lista)
                {
                    totale = p.getPrezzoScontato() + totale;
                }
                return totale;
            }
        }


        //funzioni private
        private string GeneraId()
        {
            int lung = 10;
            char[] id = new char[lung];
            int val = 0;
            for (int a = 0; a < lung; a++)
            {
                val = rnd.Next(48, 58);
                id[a] = Convert.ToChar(val);
            }
            string str = new string(id);
            return str;
        }
        private int RicercaProdotto(Prodotto p)
        {
            int pos = Lista.IndexOf(p);           
            return pos;
        }
        private int RicercaQuantitàProdotto(Prodotto p)
        {           
            int quant = 0;

            foreach(Prodotto pr in Lista)
            {
                if(p.Id == pr.Id)
                    quant++;
            }
            return quant;
        }

        private void RicompattazioneConQuantità(int pos, int quantità)
        {
            Lista.RemoveRange(pos, quantità);
        }
    }
}
