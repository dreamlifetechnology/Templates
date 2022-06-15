using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Patrones_de_diseño_creacionales._6._Adapter
{
    // Trata de comunicar interfaces distintas para que puedan interactuar entre sí.
    public class AdapterPattern
    {
        public void init()
        {

        }


    }
    public static class ProductDataProvider
    {
        public static List<Product1> GetData() =>
            new List<Product1>
            {
                new Product1("Android 1.1","500"),
                new Product1("iPhone 10","1500"),
                new Product1("Android 1.5","700")
            };
    }

    public class Product1
    {
        public Product1(string name, string price)
        {
            Name = name;
            Price = price;        
        }

        public string Name{ get; set; }
        public string Price{ get; set; }

    }

}
