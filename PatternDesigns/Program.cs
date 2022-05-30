using PatternDesigns.Builder;
using PatternDesigns.Factory;
using PatternDesigns.Factory.PizzaStore;
using PatternDesigns.Abstract_Factory;
using PatternDesigns.Prototype;
using PatternDesigns.Singleton;
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
            //testFactory.run();

            // 4. Abstract Factory
            // abstractFactory.run();

            // 5. Prototype
            //PrototypePattern.run();       // ICloneable
            //PrototypePattern2.run();      // Deep Copy con IPrototype
            //PrototypePattern3.run();      // Deep Copy con IPrototype + serializacion
            
            // 6. Singleton
            SingletonTest.run();
        }
    }
}
