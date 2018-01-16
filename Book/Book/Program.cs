using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book aapinen = new Book();
            aapinen.name = "abc-kirja";
            aapinen.author = "jeesus";
            aapinen.id = 1;
            aapinen.price = 20;

            Console.WriteLine("{0} \n author: {1} \n id: {2} \n price: {3}",aapinen.name, aapinen.author, aapinen.id, aapinen.price);
            Console.ReadLine();


    
        }
    }
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
                return "{this.Title} on kalliimpi kuin {book.Title} kirja)";
        }
            

    }
}
