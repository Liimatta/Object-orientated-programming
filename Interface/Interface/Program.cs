using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product jakoavain = new Product("Jakoavain", 15.00, 2);
            products.Add(jakoavain);
            Product vasara = new Product("Vasara", 20.00, 5);
            products.Add(vasara);
            Product kirves = new Product("Kirves", 25, 4);
            products.Add(kirves);

            
            Console.WriteLine("Hae tuotteita!");
            int k = 0;
            do
            {
                Console.WriteLine(((IProduct)products[k]).Getproduct());
                k++;
            }
            while (k < 3);
            k = 0;
            do
            {
                Console.Write("Tuotteen ");
                Console.Write(products[k].name);
                Console.Write(" kokonaisarvo on ");
                Console.WriteLine(((IProduct)products[k]).Counttotalvalue());
                k++;
            }
            while (k < 3);

            Console.Clear();
            Console.WriteLine("Hae asiakkaita");
            List<Customer> customers = new List<Customer>();
            Customer janne = new Customer("Janne", 999);
            customers.Add(janne);
            Customer pentti = new Customer("Pentti", 1560);
            customers.Add(pentti);
            Customer jorkki = new Customer("Jorkki", 4000);
            customers.Add(jorkki);

            k = 0;
            do
            {
                customers[k].GetCustomer();
                k++;
            }
            while (k < 3);
            
            Console.Clear();


            Store JannenValinta = new Store("JannenValinta", 200000);

            JannenValinta.AddCustomer(customers);
            JannenValinta.AddProduct(products);
            JannenValinta.PrintCustomers();
            Console.Clear();
            JannenValinta.PrintProducts();

            Console.ReadKey();

        }
    }
}
