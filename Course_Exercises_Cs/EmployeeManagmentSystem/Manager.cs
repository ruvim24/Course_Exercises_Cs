using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.EmployeeManagmentSystem
{
    internal class Manager : Employee
    {
        public Manager(string name, int workExperience) : base(name, workExperience)
        {    
        }
        public override decimal CalculateSalary()
        {
            return MinSalary + ((MinSalary * 30) / 100) * WorkExperience;

        }

    }
}
//salariul minim + 30% din salariu minim * experienta
