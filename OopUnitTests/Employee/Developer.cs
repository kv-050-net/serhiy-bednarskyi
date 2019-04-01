using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    public class Developer : Employee
    {
        public Developer(string firstName, string secondName, int experience, decimal salary, Manager manager)
            : base(firstName, secondName, experience, salary, manager)
        {
            //manager.AddManagerMember(this);
            // developer constructor   
        }

        public override void AddToManagerList()
        {
            Manager.AddManagerMember(this);
        }
    }
}
