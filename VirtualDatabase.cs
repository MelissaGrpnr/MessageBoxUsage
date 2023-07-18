using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxExample
{
    public static class VirtualDatabase
    {
        public static List<Customer> customers { get; set; }

         static VirtualDatabase()
        {
            customers = new List<Customer>();
        }
    }
}
