using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string name;
        public string author;
        public int id;
        public int price;

        public Book(string Name = "no name", string Author = "no author", int Id = 0, int Price = 0)
        {
            name = Name;
            author = Author;
            id = Id;
            price = Price;

        }

        public string CompareBook(Book book)
        {
            if (this.price > book.price)
                return $"{this.name} on kalliimpi kuin {book.name} kirja";
            else
                return $"{book.name} on kalliimpi kuin {this.name} kirja";
        }
        public void Askdata()
        {
            Console.WriteLine("Name");
            name = Console.ReadLine();
            Console.WriteLine("Author:");
            author = Console.ReadLine();
            Console.WriteLine("id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price");
            price = Convert.ToInt32(Console.ReadLine());
        }

    }
}
