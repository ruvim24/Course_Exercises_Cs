using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.SOLID
{

    public interface IWork
    {
        void Work();
    }
    public interface IEat
    {
        void Eat();
    }
    


    public class HumanWorker : IWork, IEat
    {
        public void Work()
        {
            Console.WriteLine("Human working...");
        }


        public void Eat()
        {
            Console.WriteLine("Human eating...");
        }
    }


    public class RobotWorker : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }
    }

}
