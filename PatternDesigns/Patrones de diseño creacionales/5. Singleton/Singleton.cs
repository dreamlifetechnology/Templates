using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDesigns.Singleton
{

    public interface ISingletonContainer
    {
        int GetPopulation(string name);
    }

    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _ciudades = new Dictionary<string, int>();

        private SingletonDataContainer()
        {
            var elements = File.ReadAllLines(@"..\\net5.0\\Comunes\\cities.txt");
            for (int i = 0; i < elements.Length - 1; i += 2)
            {
                _ciudades.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        private static SingletonDataContainer instance = new SingletonDataContainer();
        public static SingletonDataContainer Instance => instance;

        public int GetPopulation(string name)
        {
            return _ciudades[name];
        }
    }

    public class SingletonFinder
    {
        private ISingletonContainer _dataContainer;

        public SingletonFinder(ISingletonContainer dataContainer)
        {
            _dataContainer = dataContainer;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int total = 0;
            foreach (string name in names)
            {
                total += _dataContainer.GetPopulation(name);
            }
            return total;
        }


    }

    // Con inyecccion de dependencias
    public class DummyDatabase : ISingletonContainer
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["Santiago"] = 5000,
                ["Galicia"] = 500000
            }[name];
        }
    }
}
