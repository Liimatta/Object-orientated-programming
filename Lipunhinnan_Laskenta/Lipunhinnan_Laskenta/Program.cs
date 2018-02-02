using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipunhinnan_Laskenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Lippu lippu = new Lippu();
            lippu.Askdata();

            Console.WriteLine(lippu.Laskuri());

            Console.ReadKey();
        }
    }
}
