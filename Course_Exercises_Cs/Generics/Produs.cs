using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Generics
{
    internal class Produs
    {
        private string _name;
        public string Name { get { return _name; } }
        private decimal _price;
        public decimal Price { get { return _price; } }
        public Produs(string name, decimal price)
        {
            _name = name;
            _price = price;
        }
    }
}
