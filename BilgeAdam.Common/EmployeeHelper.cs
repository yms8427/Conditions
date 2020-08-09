using System;

namespace BilgeAdam.Common
{
    public class EmployeeHelper
    {
        public double GetTotalIncome(Employee employee)
        {
            var diff = DateTime.Now - employee.startDate;
            var months = Convert.ToInt16(diff.TotalDays / 30);
            return months * employee.salary;
        }

        public double GetExtraIncome(Employee employee)
        {
            if (employee.gender == Gender.Female)
            {
                var startYear = employee.startDate.Year;
                var totalYear = DateTime.Now.Year - startYear;
                return totalYear * employee.salary / 2; ;
            }
            return 0;
        }
    }
}
