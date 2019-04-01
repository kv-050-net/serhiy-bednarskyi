using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{ 
    class DeveloperSalaryCalculator : ICalculateSalary
    {
        public decimal CalculateEmployeeSallary(Employee CurrentDeveloper)
        {
            decimal salaryWithBonus = CurrentDeveloper.DefaultSalary;

            if (CurrentDeveloper.Experience > 5)
            {
                salaryWithBonus = salaryWithBonus * 1.2m;
                salaryWithBonus += 500;
            }
            else if (CurrentDeveloper.Experience > 2)
            {
                salaryWithBonus += 200;
            }

            return salaryWithBonus;
        }
    }
}
