using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma1 = new Firma();
            firma1.Askdata();

            Firma firma2 = new Firma(firma1);

            

            Console.WriteLine("Muuta firman 2 ominaisuuksia");
            firma2.Askdata();

            Console.WriteLine(firma1.Win());
            Console.WriteLine(firma2.Win());
            Console.ReadKey();

        }
    }
}
