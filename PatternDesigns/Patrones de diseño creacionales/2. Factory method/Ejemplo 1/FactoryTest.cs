using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternDesigns.Comunes.Entities;

namespace PatternDesigns.Factory
{
    public class FactoryTest
    {
        /// <summary>
        /// Permite crear objetos sin exponer su inicialización
        /// 1. Constructor lo pasamos a privado
        /// 2. Creamos clase factory para evitar romper OCP de clase Car
        /// 3. Uso de clases anidadas (factory dentro de Car) para evitar tener el constructor internal(namespace) o publico
        /// </summary>

        public void runExample()
        {
            Car ferrari = Car.Factory.createFerrari();
            Console.WriteLine($"Modelo {ferrari.modelo} con {ferrari.numCaballos} CV");
            Console.ReadLine();
        }


        public class Car
        {
            private Car(string modelo, int numCaballos)
            {
                this.modelo = modelo;
                this.numCaballos = numCaballos;
            }

            public string modelo { get; set; }
            public int numCaballos { get; set; }

            public static class Factory
            {
                public static Car createFerrari()
                {
                    return new Car("Ferrari F40", 500);
                }
            }

        }
    }
}
