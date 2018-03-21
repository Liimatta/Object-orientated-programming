using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IProducts:IProduct
    {
        void AddProduct(Product product);

        void PrintProducts();
    }
}
