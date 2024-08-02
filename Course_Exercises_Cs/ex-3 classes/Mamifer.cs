using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.ex_3_classes
{
    internal class Mamifer : Animal
    {
        private string _culoareBlana;
        public string CuloareBlana
        {
            get { return _culoareBlana; }
            set { _culoareBlana = value; }
        }
        public void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Culoare Blana: {CuloareBlana}");
        }
        public Mamifer(string name, string culoareBlana) : base(name)
        {
            CuloareBlana = culoareBlana;
        }
    }
}
