using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Abstract_Factory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            return (Pizza)Activator.
                CreateInstance(Type.GetType($"PatternDesigns.Abstract_Factory.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"),ingredientFactory);
        }
    }
}
