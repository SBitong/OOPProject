using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public class Product
    {
       
        public string Name;
        public string Description;
        public decimal Price;
        public string Manufacturer;
        public int Items;
       
       

        static void DeductItems(int items = 0)
        {

            if (items != 0)
            {
                items = items - items;
            }
            else items--;
        }
    }
}
