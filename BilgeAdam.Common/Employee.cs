using System;

namespace BilgeAdam.Common
{
    public class Employee
    {
        public Guid identity;
        public string name;
        public Gender gender;
        public DateTime startDate;
        public double salary;
    }

    public enum Gender
    {
        Male,
        Female
    }
}

//class ve enumlar için access mofier belirlenmezse internal olur.
//Örnek:
//internal class Employee
//{
//
//}
