using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Factory.PizzaStore
{

    public static class testFactory
    {
        public static void run()
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);
            Console.WriteLine($"Pizza {pizza.Name} creada");
            Console.ReadLine();
        }
    }

    public class Pizza
    {
        public string Name { get; set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparando pizza: {Name}");
            Console.WriteLine($"Masa: {Dough}");
            Console.WriteLine($"Salsa  {Sauce}");
            Console.WriteLine($"Toppings: {String.Join(",",Toppings)}");
        }

        public void Bake() => Console.WriteLine($"Cocinando pizza");
        public void Cut() => Console.WriteLine($"Cortando pizza");
        public void Box() => Console.WriteLine($"Empaquetando pizza");

    }

    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "pepperoni";
            Dough = "Fina";
            Sauce = "Sin salsa";
            Toppings.Add("Queso");                                
            Toppings.Add("Mortadel");                                
            Toppings.Add("Jamón");                                
        }
    }
    internal class NeapolitanPizza : Pizza
    {
        public NeapolitanPizza()
        {
            Name = "Napolitana";
            Dough = "Fina";
            Sauce = "Salsa napolitana";
            Toppings.Add("Tomate");
        }
    }
    internal class CaliforniaPizza : Pizza
    {
        public CaliforniaPizza()
        {
            Name = "california";
            Dough = "Fina";
            Sauce = "Salsa césar";
            Toppings.Add("Lechuga");
        }
    }


    public enum TypeOfPizza
    {
        Pepperoni, Neapolitan, California
    }

    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            //Pizza pizza = null;
            //switch (type)
            //{
            //    case TypeOfPizza.Pepperoni:
            //        return new PepperoniPizza();
            //    case TypeOfPizza.Neapolitan:
            //        return new NeapolitanPizza();
            //    case TypeOfPizza.California:
            //        return new CaliforniaPizza();
            //}
            //return pizza;

            // Ejemplo usando reflection, evitamos así crear nuevos cases cuando se necesiten
            return (Pizza) Activator.CreateInstance(Type.GetType($"PatternDesigns.Factory.PizzaStore.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));

        }
    }

    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case TypeOfPizza.Pepperoni:
                    return new PepperoniPizza();
                case TypeOfPizza.Neapolitan:
                    return new NeapolitanPizza();
                case TypeOfPizza.California:
                    return new CaliforniaPizza();
            }
            return pizza;
        }
    }

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
