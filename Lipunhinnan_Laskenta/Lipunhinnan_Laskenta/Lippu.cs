using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipunhinnan_Laskenta
{
    class Lippu
    {
        public int ikä;
        public string mtk;
        public string vm;
        public string op;


        public Lippu(int Ikä = 0, string Mtk = "e", string Vm = "e", string Op = "e")
        {
            ikä = Ikä;
            mtk = Mtk;
            vm = Vm;
            op = Op;

        }
        public void Askdata()
        {
            Console.WriteLine("Syötä tiedot");
            Console.WriteLine("Ikä");

            ikä = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Oletko MTK:n jäsen? y/n");

            mtk = Console.ReadLine();

            Console.WriteLine("Oletko varusmies? y/n");

            vm = Console.ReadLine();

            Console.WriteLine("Oletko opiskelija? y/n");

            op = Console.ReadLine();
        }
        public string Laskuri()
        {
            int a = ikä;
            char b = Convert.ToChar(mtk[0]);
            char c = Convert.ToChar(vm[0]);
            char d = Convert.ToChar(op[0]);

            if (a < 7)
                return "0e";

            else if (b == 'y' && d == 'y')
                return "Alennus-%  -60%  Hinta  6,40e";

            else if (a > 7 && a < 15)
                return "Alennus-%  -50%  Hinta  8.00e";
            else if (a > 65)
                return "Alennus-%  -50%  Hinta  8.00e";

            else if (c == 'y')
                return "Alennus-%  -50%  Hinta  8.00e";

            else if (d == 'y')
                return "Alennus-%  -45%  Hinta  8.80e";

            else if (b == 'y')
                return "Alennus-%  -15%  Hinta  13,60e";

            else
                return "Hinta  16e";
        }
    }
}
