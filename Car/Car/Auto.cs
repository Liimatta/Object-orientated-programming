using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Auto
    {
        public string brand;
        public double speed;

        public Auto(string Brand = "no brand", double Speed = 0)
        {
            brand = Brand;
            speed = Speed;
        }
        public void AskData()
        {
            Console.WriteLine("Give car information: \nBrand:");
            brand = Console.ReadLine();
            Console.WriteLine("Speed:");
            speed = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car brand: {brand} \n Car speed: {speed}");
        }
        public string Accelerate()
        {
            
            Console.WriteLine("Give value to be added to speed, negative values are not allowed");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                double accelerate = a + speed;
                speed = accelerate;
                return $"{speed}";
            }
            else
                return $"error";
            
        }
        public string Brake()
        {
            double brake = speed * 0.9;
            speed = brake;
            return $"{brake}";
        }
    }
}
