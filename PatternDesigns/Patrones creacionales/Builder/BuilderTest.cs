using PatternDesigns.Patrones_creacionales.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternDesigns.Comunes.Entities;

namespace PatternDesigns.Builder
{
    public class BuilderTest
    {
        public void runExample()
        {
            // Creamos builder 
            var gamerComputer = new ComputerAssembly(new GamerComputer());
            var basicComputer = new ComputerAssembly(new BasicComputer());

            // Ensamblamos
            gamerComputer.Assemble();
            basicComputer.Assemble();

            Console.WriteLine($"" +
                $"Ordenador para Gamer: Disco {gamerComputer.GetComputer.hardDisk.type}" +
                $" {gamerComputer.GetComputer.hardDisk.size} GB" +
                $" y {gamerComputer.GetComputer.MemorySize} GB RAM" + Environment.NewLine);      
                                             
            Console.WriteLine($"" +
                $"Ordenador básico: Disco {basicComputer.GetComputer.hardDisk.type}" +
                $" {basicComputer.GetComputer.hardDisk.size} GB" +
                $" y {basicComputer.GetComputer.MemorySize} GB RAM" + Environment.NewLine);
            
            Console.ReadLine();

        }
    }
}
