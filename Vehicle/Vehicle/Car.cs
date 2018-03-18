using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : Vehicle
    {


        protected string EngineSize;
        protected string Model;
        protected int NbrOfDoors;
        

        public Car(string type, string make, string yearModel, double price, string engineSize, string model, int nbrOfDoors) : base(type, make, yearModel, price)
        {
            EngineSize = engineSize;
            Model = model;
            NbrOfDoors = nbrOfDoors;
        }
    }
}
