using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Calculations
    {
       
        
            public static int CalculateAge(string birthDate, bool returnInMonths = false)
            {


                int age;

                DateTime now = DateTime.UtcNow;
                DateTime past = Convert.ToDateTime(birthDate);

                age = 12 * (now.Year - past.Year) + (now.Month - past.Month);
                if (returnInMonths)
                    age = age / 12;
                return age;
            }


            public static decimal CalculateInterest(decimal principalAmount, decimal monthlyRate)
            {
                decimal interest = principalAmount * (monthlyRate / 100);
                return interest;
            }

            public static decimal CalculateAccruedAmount(decimal principalAmount, decimal monthlyRate, string date, decimal interest)
            {
                return principalAmount + CalculateInterest(principalAmount, monthlyRate) * CalculateAge(date, true);
            }
        
    }
}
