using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public abstract class Cancelleria : Prodotto
    {       
        public override double getPrezzoScontato()
        {
            DayOfWeek  Giorno = DateTime.Today.DayOfWeek;
            Sconto = 3;
            if (Giorno == DayOfWeek.Tuesday || Giorno == DayOfWeek.Thursday || Giorno == DayOfWeek.Saturday)
                return base.getPrezzoScontato();
            else return Prezzo;
        }

        public Cancelleria(string nome, string descrizione, string produttore, double prezzo) : base(nome, descrizione, produttore, prezzo)
        {
            
        }
    }
}
