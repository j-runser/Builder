using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ComputerOrder
    {
        public void ConstructComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildCPU();
            computerBuilder.BuildGPU();
            computerBuilder.BuildMonitor();
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildRAM();
        }
    }
}
