using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OopUnitTests;

namespace OopUnitTesting
{
    [TestClass]
    public class SalaryTesting
    {
        private Manager testEmployee;
        private int experience = 1;
        private int salary = 1;
        Department department = new Department();
            
            public void Setup()
        {
            testEmployee = new Manager("", "", experience, salary, null);
            
        }

        [TestMethod]
        public void CalculateEmpSallary_TestExperience_7year_startSalary1000_result1700()
        {
             experience = 7;
             salary = 1000;
            int expected = 1700;

            this.Setup();

            Assert.AreEqual(department.GetSallary(testEmployee), expected);
        }

        [TestMethod]
        public void CalculateEmpSallary_TestExperience_4year_startSalary1000_result1200()
        {
             experience = 4;
             salary = 1000;
            int expected = 1200;

            this.Setup();

            Assert.AreEqual(department.GetSallary(testEmployee), expected);
        }

        [TestMethod]
        public void CalculateEmpSallary_ManagerTest_7year_startSalary1000_11members_result2000()
        {
            experience = 7;
            salary = 1000;
            int expected = 2000;

            this.Setup();

            for (int i = 0; i < 11; i++)
            {
                testEmployee.AddManagerMember(testEmployee);
            }
            decimal actual = department.GetSallary(testEmployee);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateEmpSallary_ManagerTest_7year_startSalary1000_2members_result1700()
        {
            experience = 7;
            salary = 1000;
            int expected = 1700;

            this.Setup();

            for (int i = 0; i < 2; i++)
            {
                testEmployee.AddManagerMember(testEmployee);
            }
            decimal actual = department.GetSallary(testEmployee);

            Assert.AreEqual(actual, expected);
        }
    }
}
