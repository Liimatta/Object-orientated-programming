using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Author
{
    class Book
    {
        public string Name;
        public readonly string Author;

        public string Publisher;
        public double Price;
        public static string ThemeName;
        public double Pprice
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 30)
                {
                    Price = value * 0.9;
                }
                else
                    Price = value;
            }
        }
        

        public Book(string name, string author, string publisher, double price)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            Price = price;
        }

        public void ChangeTheme()
        {
            Console.WriteLine("Anna aapiselle uusi teema");
            string newTheme = Console.ReadLine();
            ThemeName = newTheme;
            Console.WriteLine($"Aapisen uusi teema on: {ThemeName}");
        }

        public void GetData()
        {
            Console.WriteLine("Anna kirjan nimi");
            Name = Console.ReadLine();
            Console.WriteLine("Anna julkaisijan nimi");
            Publisher = Console.ReadLine();
            Console.WriteLine("Anna kirjan hinta");
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public string search()
        {
            string input = Console.ReadLine();
            return input;
            
        }

        public bool GetBook(string Search)
        {
            return (this.Name == Search);
            //string Search = search();
            //if (this.Name == Search)
            //{
            //    Console.WriteLine($"Kirjan tiedot");
            //    // {books[i].Name} {books[i].Author} {books[i].Publisher} {books[i].Price}
               
            //}
            //else
            //    Console.WriteLine("Kirjaa ei löydy");
        }

    }
}
