using System;

namespace PatternDesigns.Abstract_Factory
{
    internal class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Agregando masa fina");
        }
    }
}