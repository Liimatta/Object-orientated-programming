using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Store:ICustomers,IProducts
    {
        public string name;
        public double revenue;
        public List<Product> products;
        public List<Customer> customers;

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
            
        }

        public string ToString()
        {
            return "ToString";
        }


        public void PrintCustomers()
        {
            int i = 0;
            foreach (Customer cus in customers)
            {
                i++;
            }
            Console.WriteLine($"Asiakkaiden lukumäärä: {i}");
            int k = 0;
            do
            {
                Console.WriteLine($"Asiakas: {customers[k].name} \nOstokset: {customers[k].shoppings}");
                Console.Write("Bonus:");
                customers[k].CountBonus();
                Console.WriteLine();
                k++;

            }
            while (k < i);
            Console.ReadKey();
        }

        public void AddProduct(List<Product> product)
        {
            products = product ;
        }

        public string Counttotalvalue()
        {
            double tv = products[0].price * products[0].amount;
            return $"{tv}";
            
        }
        public string Getproduct()
        {
            return $"{products[0]}";
        }
        public void PrintProducts()
        {
            int i = 0;
            foreach (Product prod in products)
            {
                i++;
            }
            Console.WriteLine($"Tuotteiden lukumäärä: {i}");
            int k = 0;
            do
            {
                Console.WriteLine($"Tuote: {products[k].name} \nMäärä: {products[k].amount} \nHinta: {products[k].price}");
                Console.Write("Yhteisarvo:");
                Console.WriteLine(products[k].Counttotalvalue());
                Console.WriteLine();
                k++;

            }
            while (k < i);
            Console.ReadKey();
        }

        public void AddCustomer(List<Customer> customer)
        {
            customers = customer ;

        }
        
    }
}
