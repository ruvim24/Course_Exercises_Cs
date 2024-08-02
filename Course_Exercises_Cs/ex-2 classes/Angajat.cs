using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.ex_2_classes
{
    public  class Angajat
    {
        protected string _name;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"Angajt nume: {Name}");
        }
        public Angajat(string nume) 
        {
            Name = nume;
        }
    }
}
