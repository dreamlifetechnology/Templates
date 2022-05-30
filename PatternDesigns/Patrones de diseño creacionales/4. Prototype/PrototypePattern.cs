using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Prototype
{
    public static class PrototypePattern
    {
        /// <summary>
        /// Patrón de diseño, su función principal es copiar objetos existentess. 
        /// Se usa cuando el proceso de creación es complejo
        /// </summary>
        public static void run()
        {
            var producto = new Producto("Portatil Dell 15.4", new Categoria("Portatiles"));
            var producto2 = (Producto) producto.Clone();

            producto2._name = "iPhone";
            producto2._categoria.name = "smartPhones";

            Console.Write(producto.ToString());
            Console.Write(producto2.ToString());
            Console.ReadLine();
            
        }
        public class Categoria : ICloneable
        {
            public string name { get; set; }
            public Categoria(string name)
            {
                this.name = name;
            }
            
            public object Clone()
            {
                return new Categoria(name);
            }
        }

        public class Producto: ICloneable
        {
            public string _name { get; set; }
            public Categoria _categoria { get; set; }

            public Producto(string name, Categoria categoria)
            {
                _name = name;
                _categoria = categoria;
            }

            public override string ToString()
            {
                return $"Producto {_name}, Categoría: {_categoria.name}" + Environment.NewLine;
            }

            public object Clone()
            {
                return new Producto(_name, new Categoria(_categoria.name));
            }

        }
    }
}
