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

        void AddCustomer()
        {

            storeCustomers[0].name = Console.ReadLine();
        }
        void PrintCustomers()
        {
            Console.WriteLine("Asiakkaiden määrä: 1");
            Console.WriteLine($"{storeCustomers[0]}");
            Console.WriteLine(((ICustomer)storeCustomers[0]).CountBonus());
        }
        void AddProduct(Product product)
        {
            Console.WriteLine("Anna tuote");
            storeProducts[0].name = Console.ReadLine();
            Console.WriteLine("Anna määrä");
            storeProducts[0].amount = Convert.ToInt32(Console.ReadLine());
        }

        string Counttotalvalue()
        {
            double tv = storeProducts[0].price * storeProducts[0].amount;
            return $"{tv}";
            
        }
        string Getproduct()
        {
            return $"{storeProducts[0]}";
        }
        void PrintProducts()
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
