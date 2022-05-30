using System;

namespace PatternDesigns.Abstract_Factory
{
    public class Onion : IVeggie
    {
        public Onion()
        {
            Console.WriteLine("Agregando cebolla");
        }
    }
}