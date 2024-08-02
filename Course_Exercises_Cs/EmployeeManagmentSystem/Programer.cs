using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.EmployeeManagmentSystem
{
   
    internal class Programer : Employee
    {
        List<string> languges;
        public Programer(string name, int workExperience) : base(name, workExperience)  
        {
            languges = new List<string>();
        }

        public void AddLanguage(string language)
        {
            languges.Add(language);
        }
        public override decimal CalculateSalary()
        {
            decimal salary = 0;
            foreach (string languge in languges)
            {
                if (languge != "C#") 
                {
                    salary += (MinSalary * 50) / 100;
                }
                else
                {
                    salary += (MinSalary * 400) / 100;
                }
                
            }
            return salary;
        }
    }
}

//Pentru fiecare limbaj de programare cunoscut,
//la salariul minim se mai adauga 50% din salariu minim.
//Iar daca in lista se regaseste C# - se adauga 400% din salariu minim.