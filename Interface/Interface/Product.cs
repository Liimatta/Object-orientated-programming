using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Product : IProduct
    {
        public string name;
        public double price;
        public int amount;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public string ToString()
        {
            return "ToString";
        }
        public string Counttotalvalue()
        {
            double totalvalue = price * amount;
            return $"{totalvalue}";
        }
        public string Getproduct()
        {
            string search = Console.ReadLine();
            if (this.name == search)
                return $"{this.name}";
            else
                return null;

        }


    }
}
