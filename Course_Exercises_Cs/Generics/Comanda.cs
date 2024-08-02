using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Generics
{
    internal class Comanda
    {
        private int _id;
        private List<Produs> _produse;
        public int Id { get { return _id; } }
        public List<Produs> Produse { get { return _produse; } set { _produse = value; } }
        public Comanda(int id)
        {
            _id = id;
            Produse = new List<Produs>();

        }

        public void AdugareProdus(string name, decimal price)
        {
            Produs produs = new Produs(name, price);
            Produse.Add(produs);
        }
        public void EliminareProdus()
        {

        }
        public void VizualizareProduse()
        {
            foreach (Produs produs in Produse)
            { 
                Console.WriteLine("Lista Produs din Comanda");
                Console.WriteLine(produs.Name);
                Console.WriteLine(produs.Price);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
        }

    }
}
