using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Penna : Cancelleria
    {
        private string _funzionamento;

        public string Funzionamento
        {
            get { return _funzionamento; }
            set
            {
                if (value == null)
                    throw new Exception("Funzionamento invalido");
                else
                    _funzionamento = value;
            }
        }

        public Penna(string nome, string descrizione, string funzionamento, string produttore, double prezzo) : base(nome, descrizione, produttore, prezzo)
        {
            Funzionamento = funzionamento;
        } 
    }
}
