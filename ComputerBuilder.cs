using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();

        public Computer Product
        {
            get { return computer; }
        }

        public abstract void BuildMonitor();
        public abstract void BuildMotherboard();
        public abstract void BuildRAM();
        public abstract void BuildCPU();
        public abstract void BuildGPU();

    }
}
