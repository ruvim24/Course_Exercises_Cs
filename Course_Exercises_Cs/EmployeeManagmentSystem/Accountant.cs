using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.EmployeeManagmentSystem
{
    internal class Accountant : Employee
    {
        public Accountant(string name, int workExperience) : base(name, workExperience) 
        {  
        }

        public override decimal CalculateSalary()
        {
            return (((MinSalary *20)/100) * WorkExperience) + MinSalary;
        }
    }
}

//salariu minim + 20% din salariu minim pentru fiecare an de experienta.