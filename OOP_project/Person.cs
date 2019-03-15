using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Person
    {
        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public string BirthDate;
        public string Address;



        public Person(string firstName, string lastName, string middleName = " ")
        {
            FirstName = firstName;
            MiddleInitial = middleName;
            LastName = lastName;


        }

        public string GetFullName()
        {
            if (FirstName == null || MiddleInitial == null || LastName == null)
                return null;

            if (FirstName.Length > 1)
                return char.ToUpper(FirstName[0]) + FirstName.Substring(1);



            if (MiddleInitial.Length >= 1)
                return char.ToUpper(MiddleInitial[0]) + MiddleInitial.Substring(1);



            if (LastName.Length > 1)
                return char.ToUpper(LastName[0]) + LastName.Substring(1);



            return FirstName.ToUpper() + " " + MiddleInitial.ToUpper() + ". " + LastName.ToUpper();

        }

        public int GetAge()
        {
            return Calculations.CalculateAge(BirthDate);
        }
    }
}
