using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    using System;
    class Vehicle
    {
        protected string Type;
        protected string Make;
        protected string YearModel;
        protected double Price;

        public Vehicle(string type, string make, string yearModel, double price)
        {
            Type = type;
            Make = make;
            YearModel = yearModel;
            Price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Tyyppi: {Type}, /nMerkki: {Make}, /nVuosimalli{YearModel}, /nHinta{Price}");
        }
    }
}
