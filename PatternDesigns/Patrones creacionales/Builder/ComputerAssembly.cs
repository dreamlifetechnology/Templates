using PatternDesigns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternDesigns.Comunes.Entities;

namespace PatternDesigns.Patrones_creacionales.Builder
{
    public class ComputerAssembly
    {
        private ComputerBuilder _computerBuilder;

        public ComputerAssembly(ComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public void Assemble()
        {
            _computerBuilder.AddHardDisk();
            _computerBuilder.AddMemory();
            _computerBuilder.AddKeyboard();
            _computerBuilder.AddMouse();
        }

        public Computer GetComputer
        {
            get { return _computerBuilder.Computer; }
        }
    }
}
