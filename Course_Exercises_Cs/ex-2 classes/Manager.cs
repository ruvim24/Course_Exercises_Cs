using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.ex_2_classes
{
    public class Manager :Angajat
    {
        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public override void AfisareDetalii()
        {
            base.AfisareDetalii();
            Console.WriteLine($"Departament: {Department}");
        }

        public Manager(string departament, string nume) : base(nume)
        {
            _department = departament;
        }

    }
}
