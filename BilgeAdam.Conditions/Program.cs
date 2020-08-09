using System;
using BilgeAdam.Common;

namespace BilgeAdam.Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlar
            var emp1 = new Employee();
            emp1.identity = Guid.NewGuid();
            emp1.name = "Can Perk";
            emp1.gender = Gender.Male;
            emp1.startDate = new DateTime(2012, 9, 20);
            emp1.salary = 3500;

            var emp2 = new Employee();
            emp2.identity = Guid.NewGuid();
            emp2.name = "Hami Aktaş";
            emp2.gender = Gender.Male;
            emp2.startDate = DateTime.Now.AddYears(-4).AddMonths(2).AddDays(-10);
            emp2.salary = 6000;

            var emp3 = new Employee();
            emp3.identity = Guid.NewGuid();
            emp3.name = "Gamze Uysal";
            emp3.gender = Gender.Female;
            emp3.startDate = new DateTime(2016, 4, 24);
            emp3.salary = 5200;

            var emp4 = new Employee
            {
                identity = Guid.NewGuid(),
                name = "Suat Çelik",
                gender = Gender.Male,
                startDate = new DateTime(2015, 1, 28),
                salary = 5400
            };
            #endregion

            var helper = new EmployeeHelper();

            var emp1TotalIncome = helper.GetTotalIncome(emp1);
            var emp2TotalIncome = helper.GetTotalIncome(emp2);
            var emp3TotalIncome = helper.GetTotalIncome(emp3);
            var emp4TotalIncome = helper.GetTotalIncome(emp4);


            //Sadece kadın olan çalışanlara yıllık olarak prim veriliyor. 
            //Prim: aylık maaşın yarısı
            //Personel şu ana kadar ne kadar prim almış
            //Ör 1:
            //var p = MethodAdi(emp1); (p => burada 0 erkek olduğu için)
            //Ör 2:
            //emp5 için Gender Female, Maaş 1000, işe 4 sene önce girdi ise
            //var p = MethodAdi(emp5); (p => burada 2000 dönmeli)

            var emp1Extra = helper.GetExtraIncome(emp1); // 0
            var emp2Extra = helper.GetExtraIncome(emp2); // 0
            var emp3Extra = helper.GetExtraIncome(emp3); // 10400
            var emp4Extra = helper.GetExtraIncome(emp4); // 0

        }
    }
}


//TODO:Ödev
/*
 Bir adet method kişinin bu ayki maaşınının makbuzun kesmek için mesaj oluşturacak.
Sonuçta beklenen ifade:

Sayın Can Perk Bey, 2020 Ağustos ayı maaşınız: 3500 TL'dir
Sayın Gamze Uysal Hanım, 2020 Ağustos ayı maaşınız: 5200 TL'dir

şeklinde olmalıdır
 
 */