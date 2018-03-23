using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Customer:ICustomer
    {
        public string name;
        public double shoppings;

        public Customer(string name, double shoppings)
        {
            this.name = name;
            this.shoppings = shoppings;
        }

        public void CountBonus()
        {
            if (shoppings<=1000)
            {
                double bonus = 0.02 * shoppings;
                Console.WriteLine(bonus);
            }
            if (shoppings >1000 && shoppings < 2000)
            {
                double bonus = 0.03 * shoppings;
                Console.WriteLine(bonus);
            }
            if (shoppings >2000)
            {
                double bonus = 0.05 * shoppings;
                Console.WriteLine(bonus);
            }
                    
        }
        public void GetCustomer()
        {
            string search = Console.ReadLine();
            if (this.name == search)
                Console.WriteLine(this.name);
            else
                Console.WriteLine("");
        }
        public string ToString()
        {
            return "ToString";
        }

    }
}
