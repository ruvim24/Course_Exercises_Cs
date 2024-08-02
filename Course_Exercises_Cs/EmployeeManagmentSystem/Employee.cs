using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.EmployeeManagmentSystem
{
    public class Employee
    {
        private string _name;
        private int _workExperience;
        private decimal _minSalary ;

        public string Name
        {
            get => _name; 
            set => _name = value;
        }
        public int WorkExperience
        {
            get => _workExperience;
            set => _workExperience = value;
        }
        public decimal MinSalary
        {
            get => _minSalary;
            private set => _minSalary = value;
        }
        public Employee(string name, int workExperience)
        {
            Name = name;
            WorkExperience = workExperience;
            MinSalary = 10000;
        }

        public virtual decimal CalculateSalary()
        {
            return MinSalary;
        }
    }
}
