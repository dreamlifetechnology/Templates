using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Abstract_Factory
{
    public static class abstractFactory
    {
        // Creamos objetos a través de la composición de una familia de objetos.

        public static void run()
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);
            Console.WriteLine($"Pizza {pizza.Name} creada");
            Console.ReadLine();
        }
    }

    public enum TypeOfPizza
    {
        Pepperoni, Neapolitan, California
    }


}
