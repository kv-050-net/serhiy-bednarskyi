using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
   public abstract class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Experience { get; set; }
        public Manager Manager { get; set; }
        public decimal DefaultSalary { get; set; }
        public decimal CoefForDesigner { get; set; }

        public Employee(string firstName, string secondName, int experience, decimal salary, Manager manager)
        {
            FirstName = firstName;
            SecondName = secondName;
            Experience = experience;
            Manager = manager;
            DefaultSalary = salary;
        }

        public abstract void AddToManagerList();
    }
}
