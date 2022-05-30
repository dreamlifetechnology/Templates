using PatternDesigns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternDesigns.Comunes.Entities;

namespace PatternDesigns.Patrones_creacionales.Builder
{
    public class GamerComputer : ComputerBuilder
    {
        public override void AddHardDisk()
        {
            _computer.hardDisk = new HardDisk(240, TypeDisk.SDD);
        }

        public override void AddKeyboard()
        {
            _computer.Keyboard = "Dell Keyboard k1024";
        }

        public override void AddMemory()
        {
            _computer.MemorySize = 16;
        }

        public override void AddMouse()
        {
            _computer.Mouse = "Dell Mouse 10.0";
        }
    }

    public class BasicComputer : ComputerBuilder
    {
        public override void AddHardDisk()
        {
            _computer.hardDisk = new HardDisk(120, TypeDisk.HDD);
        }

        public override void AddKeyboard()
        {
            _computer.Keyboard = "Dell Keyboard k1001";
        }

        public override void AddMemory()
        {
            _computer.MemorySize = 8;
        }

        public override void AddMouse()
        {
            _computer.Mouse = "Dell Mouse 6.0";
        }
    }
}
