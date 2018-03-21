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

        string ICustomer.CountBonus()
        {
            if (shoppings<=1000)
            {
                double bonus = 0.02 * shoppings;
                return $"{bonus}";
            }
            if (shoppings < 2000)
            {
                double bonus = 0.03 * shoppings;
                return $"{bonus}";
            }
            else
            {
                double bonus = 0.05 * shoppings;
                return $"{bonus}";
            }
                    
        }
        string ICustomer.GetCustomer()
        {
            string search = Console.ReadLine();
            if (this.name == search)
                return $"{this.name}";
            else
                return null;
        }
        public string ToString()
        {
            return "ToString";
        }

    }
}
