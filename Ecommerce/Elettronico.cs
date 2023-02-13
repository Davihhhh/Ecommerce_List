using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Elettronico : Prodotto
    {
        //variabili
        private string _modello;                    

        //properties
        public string Modello
        { get { return _modello; } private set { _modello = value; } }      
              
        

        //costruttori
        public Elettronico(string nome, string modello, string descrizione, string produttore, double prezzo) : base(nome, descrizione, produttore, prezzo)
        {        
            Modello = modello;
            Sconto = 5;
        }

        //funzioni
        public override double getPrezzoScontato()
        {
            string day = GiornoDellaSettimana();
            double scontato;
            if (day == "Monday")
                scontato = (100 - Sconto) * Prezzo / 100;
            else return Prezzo;
            return scontato;
        }
        private string GiornoDellaSettimana()
        {
            Giorno = DateTime.Today.DayOfWeek;
            return Giorno.ToString();
        }
        public override string ToString()
        {
            string str = this.Id + Sp + this.Nome + Sp + this.Modello + Sp + this.Produttore + Sp + this.Descrizione + Sp + this.Prezzo;
            return str;
        }
    }
}
