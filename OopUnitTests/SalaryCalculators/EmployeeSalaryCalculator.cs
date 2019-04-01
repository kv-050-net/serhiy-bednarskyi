using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    class EmployeeSalaryCalculatorsFactory
    {
        
        public ICalculateSalary ReturnSalaryCalculator(Employee CurrentEmployee)
        {
            if(CurrentEmployee is Developer)
                return new DeveloperSalaryCalculator();

            if (CurrentEmployee is Designer)
                return new DesignerSalaryCalculator();

            if (CurrentEmployee is Manager)
                return new ManagerSalaryCalculator();

            else
                throw new FormatException("Invalid employee type"); 
        }

    }
}
