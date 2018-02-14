using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
        }

        public override void BuildCPU()
        {
            computer.CpuName = "Intel Core i9-7920XE";
            computer.Cost += 1099.99;
        }

        public override void BuildGPU()
        {
            computer.GpuName = "NVIDA Titatn Xp: Jedi Order";
            computer.Cost += 1138.00;
        }

        public override void BuildMonitor()
        {
            computer.MonitorName = "LG 34\" UltraWide Full HD IPS Cured LED Monitor with G-SYNC";
            computer.Cost += 899.99;
        }

        public override void BuildMotherboard()
        {
            computer.MotherboardName = "ASUS Prime X299-Delux";
            computer.Cost += 500.54;
        }

        public override void BuildRAM()
        {
            computer.RamName = "Dominator Platinum Series DDR4 DRAM 3200MHz 128GB";
            computer.Cost += 1864.99;
        }
    }
}
