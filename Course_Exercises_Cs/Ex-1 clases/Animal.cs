using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Ex_1_clases
{
    public abstract class Animal
    {
        public abstract void MakeSound();
        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }
}
