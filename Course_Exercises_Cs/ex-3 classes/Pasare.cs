using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.ex_3_classes
{
    internal class Pasare : Animal
    {
        private string _tipZbor;
        public string TipZbor
        {
            get { return _tipZbor; }
            set { _tipZbor = value; }
        }
        public override void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Tip Zbor: {TipZbor}");
        }
        public Pasare(string name, string tipZbor) : base(name)
        {
            _tipZbor = tipZbor;
        }
    }
}
