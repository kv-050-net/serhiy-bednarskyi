using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    class ManagerSalaryCalculator : ICalculateSalary
    {
        public decimal CalculateEmployeeSallary(Employee currentManager)
        {
            Manager CurrentManager = (Manager)currentManager;
            decimal SalaryWithBonus = CurrentManager.DefaultSalary;

            if (CurrentManager.Experience > 5)
            {
                SalaryWithBonus = SalaryWithBonus * 1.2m;
                SalaryWithBonus += 500;
            }
            else if (CurrentManager.Experience > 2)
            {
                SalaryWithBonus += 200;
            }

            if (CurrentManager.ManagerMember.Count > 10)
            {
                SalaryWithBonus += 300m;
            }
            else if (CurrentManager.ManagerMember.Count > 5)
            {
                SalaryWithBonus += 200m;
            }

            decimal DevelopersCount = 0;

            for (int i = 0; i < CurrentManager.ManagerMember.Count; i++)
            {
                if (CurrentManager.ManagerMember[i] is Developer)
                {
                    DevelopersCount++;
                }
            }

            if (DevelopersCount > (CurrentManager.ManagerMember.Count / 2))
                SalaryWithBonus *= 1.1m;

            return SalaryWithBonus;
        }
    }
}
