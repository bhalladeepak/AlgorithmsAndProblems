using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiValueDictionary<string, string> creatures = new MultiValueDictionary<string, string>();
            creatures.Add("birds","eagle");
            creatures.Add("birds", "dove");

            creatures.Add("animals", "tiger");

            var itemsRemoved = creatures.RemoveKey("animals");
            Console.WriteLine(itemsRemoved);

            var values = creatures.Get("birds");
            foreach (var v in values)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();

        }
    }
}

