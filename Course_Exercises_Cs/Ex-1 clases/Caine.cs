using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Ex_1_clases
{
    public class Caine : Animal, IRunable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ham ham ham");
        }
        public override void Eat()
        {
            Console.WriteLine("Cainele mamanca");
        }
        public void Run()
        {
            Console.WriteLine("Cainele alearga");
        }
    }
}
