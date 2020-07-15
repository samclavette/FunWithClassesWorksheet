using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    class RAM
    {
        public string brand;
        public double totalGigabytes;

        public RAM(string brand, double totalGigabytes)
        {
            this.brand = brand;
            this.totalGigabytes = totalGigabytes;
        }
    }
}
