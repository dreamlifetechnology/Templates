using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Singleton
{
    public static class SingletonTest
    {
        /// <summary>
        /// Crear una instancia de un objeto y esta compartirla por toda la aplicación.
        /// </summary>
        public static void run()
        {
            var ciudades = SingletonDataContainer.Instance;
            Console.WriteLine($"1. Los habitantes de Madrid son {ciudades.GetPopulation("Madrid")}");

            // var finder = new SingletonFinder();
            // var total = finder.GetTotalPopulation(new[] { "Madrid","Barcelona"});

            // Ejemplo para extender la funcionalidad de Singleton con inyeccion de dependencia
            // Usando una base de datos no de producción
            var finder = new SingletonFinder(new DummyDatabase());
            var total = finder.GetTotalPopulation(new[] { "Galicia", "Santiago" });

            Console.WriteLine($"2. Los habitantes de Galicia y Santiago son {total}");
            Console.ReadLine();

        }
    }
}
