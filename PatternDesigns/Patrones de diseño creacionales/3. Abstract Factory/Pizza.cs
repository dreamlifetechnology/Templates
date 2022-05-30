using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Abstract_Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough;
        protected ISauce Sauce;
        protected ICheese Cheese;
        protected List<IVeggie> Veggies = new List<IVeggie>();

        public abstract void Prepare();

        public void Bake() => Console.WriteLine($"Cocinando pizza");
        public void Cut() => Console.WriteLine($"Cortando pizza");
        public void Box() => Console.WriteLine($"Empaquetando pizza");

    }
}
