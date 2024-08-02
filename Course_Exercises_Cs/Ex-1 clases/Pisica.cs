using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Ex_1_clases
{
    internal class Pisica : Animal, IRunable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat miau");
        }
        public override void Eat()
        {
            Console.WriteLine("Pisica mananca peste");
        }
        public void Run()
        {
            Console.WriteLine("Cat runs");
        }
    }
}
