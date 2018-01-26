using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give vehicle info");

            Auto newAuto = new Auto();
            newAuto.AskData();

            Auto newAuto2 = new Auto();
            newAuto2.AskData();

            newAuto.ShowCarInfo();
            newAuto2.ShowCarInfo();

            Console.WriteLine("Press 1 to accelerate or 2 to brake");
            int o = Convert.ToInt32(Console.ReadLine());

            if (o == 1)
            {
                newAuto.Accelerate();
                newAuto2.Accelerate();
                Console.WriteLine($"{newAuto.speed} \n{newAuto2.speed}");
                
            }
            else if (o == 2)
            {
                newAuto.Brake();
                newAuto2.Brake();
                Console.WriteLine($"{newAuto.speed} \n{newAuto2.speed}");
            }
            else
            {
                Console.WriteLine("Exit");
            }
            Console.ReadKey();

        }
    }
}
