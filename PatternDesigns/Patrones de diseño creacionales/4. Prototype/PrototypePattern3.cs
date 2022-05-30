using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PatternDesigns.Prototype
{

    public static class ExtensionMethods
    {

        public static T DeepCopy<T>(this T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            stream.Close();
            
            return (T)copy;
        }
    }


    // Deep Copy
    public static class PrototypePattern3
    {
        /// <summary>
        /// Patrón de diseño, su función principal es copiar objetos existentess. 
        /// Se usa cuando el proceso de creación es complejo
        /// </summary>
        public static void run()
        {
            var producto = new Producto("Portatil Dell 15.4", new Categoria("Portatiles"));
            var producto2 = (Producto)producto.DeepCopy();

            producto2._name = "iPhone";
            producto2._categoria.name = "smartPhones";

            Console.Write(producto.ToString());
            Console.Write(producto2.ToString());
            Console.ReadLine();

        }


        [Serializable]
        public class Categoria 
        {
            public string name { get; set; }
            public Categoria(string name)
            {
                this.name = name;
            }

            //public Categoria DeepCopy()
            //{
            //    return new Categoria(name);
            //}
        }

        [Serializable]
        public class Producto 
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

            //public Producto DeepCopy()
            //{
            //    return new Producto(_name, _categoria.DeepCopy());
            //}
        }

    }
}
