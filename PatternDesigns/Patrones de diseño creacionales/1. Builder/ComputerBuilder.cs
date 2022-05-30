using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternDesigns.Comunes.Entities;

namespace PatternDesigns.Builder
{
    /// <summary>
    /// Patrón para crear objetos complejos.
    /// </summary>    
    public abstract class ComputerBuilder
    {
        protected Computer _computer = new Computer();
        public Computer Computer { get { return _computer; }}
        public abstract void AddHardDisk();
        public abstract void AddMemory();
        public abstract void AddKeyboard();
        public abstract void AddMouse();
    }
}
