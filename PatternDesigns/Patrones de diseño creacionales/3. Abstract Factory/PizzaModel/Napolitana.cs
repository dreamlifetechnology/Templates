using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Abstract_Factory
{
    internal class Napolitana : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public Napolitana(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            //Name = "Napolitana";
            //Dough = "delgada";
            //Sauce = "Salsa de tomate";
            //Toppings.Add("Peperoni");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparando pizza: {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
