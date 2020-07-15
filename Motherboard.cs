using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    class Motherboard
    {
        public string manufacturer;
        public GPU graphics;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;

        public Motherboard(string manufacturer, GPU graphics, CPU processor, RAM temporaryMemory, HardDrive storage)
        {
            this.manufacturer = manufacturer;
            this.graphics = graphics;
            this.processor = processor;
            this.temporaryMemory = temporaryMemory;
            this.storage = storage;
        }

        public void InstallApplication(Applications application)
        {
            if (temporaryMemory.totalGigabytes > application.requiredRam && storage.availableStorage > application.requiredStorage)
            {
                storage.applicationsOnHardDrive.Add(application);
            }
        }


    }
}
