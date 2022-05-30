using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Abstract_Factory
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);

        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
