using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Truck : Car
    {
        protected int LoadWeight;
        protected int MPG;



        public Truck(int loadWeight, int mPG) : base( Type, Make, Yearmodel, Price, EngineSize, Model, NbrOfDoors)
        {
            LoadWeight = loadWeight;
            MPG = mPG;

        }

    

        

    }
}
