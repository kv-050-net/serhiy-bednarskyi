using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopUnitTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            Manager manager1 = new Manager("Anatolii", "Managerskyi", 7, 1000, null);
            Manager manager2 = new Manager("Serhii", "Tojmanager", 3, 600, manager1);

            manager2.AddToManagerList();
        
            department.AddToManagerList(manager1);
            department.AddToManagerList(manager2);

            Designer designer1 = new Designer("Klark", "Designerskyi", 3, 1000, manager1, 0.9m);
            designer1.AddToManagerList();

            Designer designer2 = new Designer("Toni", "Koshkin", 10, 1500, manager2, 0.7m);
            designer2.AddToManagerList();

            Designer designer3 = new Designer("Vitalii", "Designerskyi", 3, 900, manager1, 0.9m);
            designer3.AddToManagerList();

            Developer dev1 = new Developer("Antoni", "Developerskyi", 3, 500, manager2);
            dev1.AddToManagerList();

            Developer dev2 = new Developer("Qver", "Devchik", 9, 3000, manager1);
            dev2.AddToManagerList();

            //department.GetSallary(manager1);

            Console.WriteLine(department.GetSallary(dev1)); 

            Console.ReadKey();
        }
    }
}
