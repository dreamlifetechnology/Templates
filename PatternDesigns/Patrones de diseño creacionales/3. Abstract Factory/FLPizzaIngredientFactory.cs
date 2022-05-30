using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Abstract_Factory
{
    public class FLPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new Onion(), new Garlic() };
        }
    }
}
