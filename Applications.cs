using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    class Applications
    {
        public string applicationName;
        public string applicationType;
        public double requiredRam;
        public double requiredStorage;

        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messaging Service";
            requiredRam = 4.0; //in gigabytes
            requiredStorage = 0.512; //int gigabytes
        }

    }
}
