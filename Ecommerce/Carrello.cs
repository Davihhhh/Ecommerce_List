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
        private int _contatore;
        private int _limiteCarrello;
        private Prodotto[] _lista;

        private const int DefaultLimite = 1000;
        private Random rnd = new Random();

        //properties
        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        public int Contatore
        {
            get { return _contatore; }
            private set { _contatore = value; }
        }
        public int LimiteCarrello
        {
            get { return _limiteCarrello; }
            private set { _limiteCarrello = value; }
        }
        public Prodotto[] Lista
        {
            get { return _lista; }
            private set { _lista = value; }
        }

        //costruttori        
        public Carrello(int limiteCarrello)
        {           
            Id = GeneraId();
            LimiteCarrello = limiteCarrello;
            Lista = new Prodotto[LimiteCarrello];
            Contatore = 0;
        }
        public Carrello() : this(DefaultLimite)
        {
            LimiteCarrello = DefaultLimite;           
            Lista = new Prodotto[DefaultLimite];
            Contatore = 0;

        }


        //funzioni pubbliche
        public void AggiungiProdotto(Prodotto p, int quantità)
        {
            if (Contatore >= LimiteCarrello || p == null || quantità < 1 || (quantità+Contatore) > LimiteCarrello)
            {
                throw new Exception("aggiunta invalida");
            }
            else
            {
                int limite = quantità + Contatore;
                for (int a = Contatore; a < limite; a++)
                {
                    //Lista[a] = p.Clone();
                    Contatore++;
                }                      
            }
        }
        public Prodotto RimuoviProdotto(Prodotto p, int quantità)
        {
            if (Contatore <= 0)
            {
                throw new Exception("Carrello vuoto o invalido");
            }
            else
            {
                int pos = RicercaProdotto(p.Id);
                if (pos < 0)
                {
                    throw new Exception("Prodotto non presente");
                }
                else
                {
                    int quantità_effettiva = RicercaQuantitàProdotto(p.Id);
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
            if (Contatore <= 0)
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
            if (Contatore <= 0)
            {
                throw new Exception("Carrello vuoto o invalido");
            }
            else
            {
                int pos = RicercaProdotto(p.Id);
                if (pos < 0)
                {
                    throw new Exception("Prodotto non presente");
                }
                else
                {
                    int quantità = RicercaQuantitàProdotto(p.Id);
                    RicompattazioneConQuantità(pos, quantità);
                }
            }
        }
        public Prodotto[] Svuota()
        {
            Prodotto[] value = Lista;
            Lista = new Prodotto[1000];
            return value;
        }
        public Prodotto[] GetProdotti()
        {
            return Lista;
        }

        public double getPrezzo()
        {
            if (Lista == null || Contatore <= 0)
                throw new Exception("Lista invalida");
            else
            {
                double totale = 0;
                for(int a = 0; a < Contatore; a++)
                {
                    totale = Lista[a].Prezzo + totale;
                }
                return totale;
            }
        }
        public double getPrezzoScontato()
        {
            if (Lista == null || Contatore <= 0)
                throw new Exception("Lista invalida");
            else
            {
                double totale = 0;
                for (int a = 0; a < Contatore; a++)
                {
                    totale = Lista[a].getPrezzoScontato() + totale;
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
        private int RicercaProdotto(string id)
        {
            int pos = -1;
            for (int a = 0; a < Contatore; a++)
            {
                if (Lista[a].Id == id)
                {
                    pos = a;
                    return pos;
                }
            }
            return pos;
        }
        private int RicercaQuantitàProdotto(string id)
        {
            int pos = -1;
            int quant = 0;
            for (int a = 0; a < Contatore; a++)
            {
                if (Lista[a].Id == id)
                {
                    pos = a;
                    a = Contatore;
                }
            }
            if (pos == -1)
            {
                return quant;
            }
            else
            {
                for (int a = pos; a < Contatore; a++)
                {
                    if (Lista[a].Id == id)
                    {
                        quant++;
                    }
                    else a = Contatore;
                }
                return quant;
            }
        }
        
        private void RicompattazioneConQuantità(int pos, int quantità)
        {
            int lung = pos + quantità;
            for (int a = pos; a < Contatore; a++, lung++)
            {
                Lista[a] = Lista[lung];
            }
        }
    }
}
