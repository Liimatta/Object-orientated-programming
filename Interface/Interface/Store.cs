using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Store:ICustomers,IProducts
    {
        public string name;
        public double revenue;

        Customer[] storeCustomers = new Customer[3];

        Product[] storeProducts = new Product[3];

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;

        }

        public string ToString()
        {
            return "ToString";
        }

        public void AddCustomer()
        {

            storeCustomers[0].name = Console.ReadLine();
        }
        public void PrintCustomers()
        {
            Console.WriteLine("Asiakkaiden määrä: 1");
            Console.WriteLine($"{storeCustomers[0]}");
            Console.WriteLine(((ICustomer)storeCustomers[0]).CountBonus());
        }
        public void AddProduct()
        {
            Console.WriteLine("Anna tuote");
            string prodname = Console.ReadLine();
            storeProducts[0].name = prodname;
            Console.WriteLine("Anna määrä");
            storeProducts[0].amount = Convert.ToInt32(Console.ReadLine());
        }

        public string Counttotalvalue()
        {
            double tv = storeProducts[0].price * storeProducts[0].amount;
            return $"{tv}";
            
        }
        public string Getproduct()
        {
            return $"{storeProducts[0]}";
        }
        public void PrintProducts()
        {
            int p = 0;
            do
            {
                Console.WriteLine($"Tuotteiden määrä: {storeProducts[p].amount}");
                Console.WriteLine($"Tuote: {storeProducts[p].name}");
                Console.WriteLine("Tuotteiden kokonaisarvo:");
                Console.WriteLine(((IProduct)storeProducts[p]).Counttotalvalue());
                p++;
            }
            while (p < 1);
        }
        
    }
}
