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

            Console.WriteLine("Give book info");

            Book newBook= new Book();
            newBook.Askdata();

            Book book2 = new Book();
            book2.Askdata();


            Console.WriteLine(newBook.CompareBook(book2));
            Console.ReadLine();


    
        }
    }
    
}
