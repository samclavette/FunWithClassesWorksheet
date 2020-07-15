using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    class CPU
    {
        public string manufacturer;
        public string name;

        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            bool checkRequirements = CheckRequirements(app, hardDrive, ram);
            if (checkRequirements == true)
            {
                hardDrive.applicationsOnHardDrive.Add(app);
            }
            else
            {
                Console.WriteLine("Cannot install application.");
            }
        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (hardDrive.availableStorage > app.requiredStorage && ram.totalGigabytes > app.requiredRam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
