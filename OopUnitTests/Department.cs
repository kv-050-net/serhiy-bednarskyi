using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    public class Department
    {
        EmployeeSalaryCalculatorsFactory employeeFactory = new EmployeeSalaryCalculatorsFactory();
        Dictionary<Type, ICalculateSalary> dictionaryEmployee = new Dictionary<Type, ICalculateSalary>(); 

        private List<Manager> managerList = new List<Manager>();

        public void AddToManagerList(Manager emp)
        {
            if(!managerList.Contains(emp))
            managerList.Add(emp);
        }

        public decimal GetSallary(Employee currentEmployee)
        {
            Type employeeType = currentEmployee.GetType();

            if (!dictionaryEmployee.ContainsKey(employeeType))
            {
                dictionaryEmployee.Add(employeeType, employeeFactory.ReturnSalaryCalculator(currentEmployee));

              return  dictionaryEmployee[employeeType].CalculateEmployeeSallary(currentEmployee);
            }
            else
            {
              return dictionaryEmployee[employeeType].CalculateEmployeeSallary(currentEmployee);
            }

        }

        public void ShowAll()
        {
            foreach (Manager man in managerList)
            {
                GetSallary(man);
                foreach (Employee emp in man.ManagerMember)
                {
                    if(emp.GetType() != typeof(Manager))
                    GetSallary(emp);
                }
            }
        }
    }
}
