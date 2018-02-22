using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Book_Author
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2];
            books[0] = new Book("aapinen", "jesse", "otava", 100);

            books[1] = new Book("Osakesäästämisen abc", "Janne", "otava", 30);


            Console.WriteLine("Anna kirjan nimi");

            
            int i = 0;
            string Search = Console.ReadLine();
            do
            {
                if (books[i].GetBook(Search))
                {
                    Console.WriteLine($"Title: {books[i].Name} \nAuthor: {books[i].Author}  \nPrice: {books[i].Price}  \nPublisher: {books[i].Publisher}");
                    break;
                }
                else
                    i++;
            }
            while (i < 2);
            if (i == 2)
                Console.WriteLine("Kirjaa ei löytynyt");

            books[0].ChangeTheme();
            Console.WriteLine("Anna Aapiselle uusi hinta");
            books[0].Pprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Aapisen hinta on:");
            System.Console.WriteLine(books[0].Price);

            Console.WriteLine($"Aapisen kirjoittaja on: {books[0].Author}");

            Console.ReadKey();

        }


    }
        
    
}
