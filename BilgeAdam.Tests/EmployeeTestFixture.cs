using System;
using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilgeAdam.Tests
{
    [TestClass]
    public class EmployeeTestFixture
    {
        [TestMethod]
        public void CalculatesEmployeeSalary()
        {
            var helper = new EmployeeHelper();

            var employee = new Employee
            {
                startDate = DateTime.Now.AddYears(-1),
                salary = 1000
            };
            var total = helper.GetTotalIncome(employee);
            Assert.AreEqual(12000, total);
        }

        [TestMethod]
        public void CalculatesFemaleExtraIncome()
        {
            var helper = new EmployeeHelper();
            var employee = new Employee
            {
                gender = Gender.Female,
                startDate = DateTime.Now.AddYears(-2),
                salary = 2000
            };
            var extra = helper.GetExtraIncome(employee);
            Assert.AreEqual(2000, extra);
        }

        [TestMethod]
        public void NotCalculatesMaleExtraIncome()
        {
            var helper = new EmployeeHelper();
            var employee = new Employee
            {
                gender = Gender.Male,
                startDate = DateTime.Now.AddYears(-2),
                salary = 2000
            };
            var extra = helper.GetExtraIncome(employee);
            Assert.AreEqual(0, extra);
        }
    }
}
