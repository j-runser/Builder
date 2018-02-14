using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Computer
    {
        private double cost;

        private String monitor;
        private String motherboard;
        private String ram;
        private String cpu;
        private String gpu;

        public Computer()
        {
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string MonitorName { get => monitor; set => monitor = value; }
        public string MotherboardName { get => motherboard; set => motherboard = value; }
        public string RamName { get => ram; set => ram = value; }
        public string CpuName { get => cpu; set => cpu = value; }
        public string GpuName { get => gpu; set => gpu = value; }

        public override String ToString()
        {
            String retval = "Current build\n";

            retval += "CPU: " + cpu + "\n";
            retval += "GPU: " + gpu + "\n";
            retval += "RAM: " + ram + "\n";
            retval += "Monitor: " + monitor + "\n";
            retval += "Motherboard: " + motherboard + "\n";

            return retval;
        }
    }
}
