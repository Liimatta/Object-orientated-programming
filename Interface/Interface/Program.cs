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
            Product[] product = new Product[3];
            product[0] = new Product("Jakoavain", 15.00, 2);
            product[1] = new Product("Vasara", 20.00, 5);
            product[2] = new Product("Kirves", 25, 4);
            Console.WriteLine("Hae tuotteita!");
            int k = 0;
            do
            {
                Console.WriteLine(((IProduct)product[k]).Getproduct());
                k++;
            }
            while (k < 3);
            k = 0;
            do
            {
                Console.Write("Tuotteen ");
                Console.Write(product[k].name);
                Console.Write(" kokonaisarvo on ");
                Console.WriteLine(((IProduct)product[k]).Counttotalvalue());
                k++;
            }
            while (k < 3);

            Console.Clear();
            Console.WriteLine("Hae asiakkaita");
            Customer[] customer = new Customer[3];
            customer[0] = new Customer("Janne", 999);
            customer[1] = new Customer("Pentti", 1560);
            customer[2] = new Customer("Jorkki", 4000);
            k = 0;
            do
            {
                Console.WriteLine(((ICustomer)customer[k]).GetCustomer());
                k++;
            }
            while (k < 3);
            k = 0;
            do
            {
                Console.WriteLine($"Asiakkaan {customer[k].name} bonus: ");
                Console.WriteLine(((ICustomer)customer[k]).CountBonus());
                k++;
            }
            while (k < 3);

            Console.Clear();
            Console.WriteLine("Osa 4");
            Store JannenValinta = new Store("jannenValinta", 200000);
            


            

            Console.ReadKey();

        }
    }
}
