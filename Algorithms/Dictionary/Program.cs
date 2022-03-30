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

            Console.WriteLine();
            Console.WriteLine("Extension method example");
            var listExtension = creatures.GetList("birds");
            foreach (var v in listExtension)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();
            Console.WriteLine("Utility method example");
            var listUtility = MultiValueDictionaryUtility.GetList(creatures, "birds");
            foreach (var v in listUtility)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();
            Console.WriteLine("Add multiple values");
            string[] mamalArray = new string[] { "dolphin", "turtle", "dolphin" };
            creatures.AddAll("mamal", mamalArray);

            var listMamal = MultiValueDictionaryUtility.GetList(creatures, "mamal");
            foreach (var v in listMamal)
            {
                Console.WriteLine(v);
            }


            Console.ReadLine();

        }
    }
}

