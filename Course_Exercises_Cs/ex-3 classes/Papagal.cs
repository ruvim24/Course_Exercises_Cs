using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.ex_3_classes
{
    internal class Papagal : Pasare
    {
        private string _vocabular;
        public string Vocabular
        {
            get { return _vocabular; }
            set { _vocabular = value; }
        }
        public override void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Vocabular Papagal: {Vocabular}");
        }
        public Papagal(string name, string vocabular, string tipZbor) : base(name, tipZbor)
        {
            _vocabular = vocabular;
        }
    }
}
