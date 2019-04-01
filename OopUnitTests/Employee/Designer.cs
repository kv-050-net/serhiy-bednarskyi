using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    public class Designer : Employee
    {
        public Designer(string firstName, string secondName, int experience, decimal salary, Manager manager, decimal effCoef)
           : base(firstName, secondName, experience, salary, manager)
        {
            //manager.AddManagerMember(this);
            base.CoefForDesigner = effCoef;
        }

        public override void AddToManagerList()
        {
            Manager.AddManagerMember(this);
        }
    }
}
