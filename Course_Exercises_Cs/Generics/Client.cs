using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Generics
{
    internal class Client
    {
        private string _name;
        private Comanda _comanda;
        private List<Comanda> _istoricComenzi;
        public string Name { get { return _name; } }
        public Comanda Comanda { get { return _comanda; } }
        //public List<Comanda> IstoricComenzi { get { return IstoricComenzi; } }
        public Client(string name)
        {
            _name = name;
            _istoricComenzi = new List<Comanda>();
            //_comanda = new Comanda(IstoricComenzi.Count);

        }

        public void AdaugareComanda()
        {

        }
        public decimal PretComanda()
        {
            decimal price = 0;
            foreach(Produs com in Comanda.Produse )
            {
                price += com.Price;
            }
            return price;
        }


    }
}
