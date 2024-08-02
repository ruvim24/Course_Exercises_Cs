using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.ex_3_classes
{
    public  class Animal
    {
        public string _name;
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"Nume animal: {Name}");
        }
        public Animal(string name)
        {
            Name = name;
        }

    }
}
