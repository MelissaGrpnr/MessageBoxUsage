﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxExample
{
   public class Customer
    {

        public Guid id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }

        public override string ToString()
        {
            return name + " " + surname;
        }
    }

}
