﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastreCustomer
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name,string email)
        {
            Name = name;
            Email = email;
        }
    }
}
