using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public class Person
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

            string fullname = "";
            if (FirstName.Length > 1)
                 fullname = char.ToUpper(FirstName[0]) + FirstName.Substring(1);



            if (MiddleInitial.Length >= 1)
                fullname = fullname + " " + char.ToUpper(MiddleInitial[0]) + "." /*+ MiddleInitial.Substring(1)*/;



            if (LastName.Length > 1)
                fullname = fullname + " " + char.ToUpper(LastName[0]) + LastName.Substring(1);



            return fullname;

        }

        public int GetAge()
        {
            return Calculations.CalculateAge(BirthDate);
        }
        private string FormatName(string name)
        {
            name = name.ToLower();
            string[] names = name.Split(' ');
            string formattedName = "";
            for (int x = 0; x < names.Length; x++)
                formattedName = formattedName + char.ToUpper(names[x][0]) + names[x].Substring(1) + " ";
            return formattedName.Remove(formattedName.Length - 1);
        }
    }
}
