﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICustomers
    {
        void AddCustomer(List<Customer> customers);

        void PrintCustomers();
    }
}
