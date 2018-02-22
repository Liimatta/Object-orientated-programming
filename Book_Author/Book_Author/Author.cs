using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literature

{
    class Author
    {
        public string Name;
        public string Birthday;
        public Book Book;

        public Author(string name, string birthday, Book book)
        {
            Name = name;
            Birthday = birthday;
            Book = book;
        }
        public void Printinfo()
        {
            Console.WriteLine($"Nimi: {Name} \nSyntymäpäivä: {Birthday} \nKirja: {this.Book.Name}");

        }




    }
    
}
