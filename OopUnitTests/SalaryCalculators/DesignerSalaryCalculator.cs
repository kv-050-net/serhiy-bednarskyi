using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    class DesignerSalaryCalculator : ICalculateSalary
    {
        public decimal CalculateEmployeeSallary(Employee CurrrentDesigner)
        {
            decimal salaryWithBonus = CurrrentDesigner.DefaultSalary;

            if (CurrrentDesigner.Experience > 5)
            {
                salaryWithBonus = salaryWithBonus * 1.2m;
                salaryWithBonus += 500;
            }
            else if (CurrrentDesigner.Experience > 2)
            {
                salaryWithBonus += 200;
            }

            return salaryWithBonus * CurrrentDesigner.CoefForDesigner;
        }
    }
}
