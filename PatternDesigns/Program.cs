using PatternDesigns.Builder;
using PatternDesigns.Factory;
using PatternDesigns.Factory.PizzaStore;
using System;

namespace PatternDesigns
{
    class Program
    {
        static void Main(string[] args)
        {

            /// PATRONES DE DISEÑO ///

            // 1. Builder
            //BuilderTest test = new BuilderTest();
            //test.runExample();

            // 2. Factory (Ejemplo1)
            //FactoryTest test = new FactoryTest();
            //test.runExample();

            // 3. Factory (Ejemplo2)
            testFactory.run();
        }
    }
}
