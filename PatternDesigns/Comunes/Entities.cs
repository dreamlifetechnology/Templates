using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Comunes
{
    public class Entities
    {

        public enum TypeDisk { HDD, SDD }

        public class HardDisk
        {
            public HardDisk(int size, TypeDisk type)
            {
                this.size = size;
                this.type = type;
            }

            public int size { get; set; }
            public TypeDisk type { get; set; }
        }

        // sealed
        public class Computer
        {
            public HardDisk hardDisk { get; set; }
            public int MemorySize { get; set; }
            public string Mouse { get; set; }
            public string Keyboard { get; set; }

            public Computer()
            {
                
            }

            public Computer(HardDisk hardDisk, int memorySize, string mouse, string keyboard)
            {
                this.hardDisk = hardDisk;
                MemorySize = memorySize;
                Mouse = mouse;
                Keyboard = keyboard;
            }

            public override string ToString()
            {
                return $"Mi ordenador tiene un disco {hardDisk.type} de {hardDisk.size} GB y {MemorySize} GB de memoria";
            }
        }


    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             