using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    public class Manager : Employee
    {
        public List<Employee> ManagerMember { get; } = new List<Employee>();

        public void AddManagerMember(Employee employee)
        {
            ManagerMember.Add(employee);
        }

        public Manager(string firstName, string secondName, int experience, decimal salary, Manager manager)
            : base(firstName, secondName, experience, salary, manager)
        {
            // manager constructor  
            //if(manager != null)
            //manager.AddManagerMember(this);
        }

        public override void AddToManagerList()
        {
            Manager.AddManagerMember(this);
        }

    }
        
}

