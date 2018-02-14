using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
        }

        public override void BuildCPU()
        {
            computer.CpuName = "Intel Core i7-7567U";
            computer.Cost += 788.51;
        }

        public override void BuildGPU()
        {
            computer.GpuName = "NVIDA GeForce GTX 1080";
            computer.Cost += 549.00;
        }

        public override void BuildMonitor()
        {
            computer.MonitorName = "Integrated Monitor";
            computer.Cost += 237.87;
        }

        public override void BuildMotherboard()
        {
            computer.MotherboardName = "Integrated Logic Board";
            computer.Cost += 772.99;
        }

        public override void BuildRAM()
        {
            computer.RamName = "Corsair Vengeance DDR4 SODIMM 64GB, 2666MHz";
            computer.Cost += 814.99;
        }
    }
}
