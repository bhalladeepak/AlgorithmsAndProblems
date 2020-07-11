using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //https://www.geeksforgeeks.org/adapter-pattern/
    interface IBird
    {
        void Fly();
        void MakeSound();
    }

    public class Sparrow : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }

        public void MakeSound()
        {
            Console.WriteLine("Chrip Chrip");
        }
    }

    interface IToyDuck
    {
        void Squeak();
    }

    public class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class BirdAdapter : IToyDuck
    {
        private readonly Sparrow _sparrow;

        public BirdAdapter(Sparrow sparrow)
        {
            _sparrow = sparrow;
        }

        public void Squeak()
        {
            _sparrow.MakeSound();
        }
    }

    public class AdapterPattern
    {
        public static void AdapterExample()
        {
            Sparrow sparrow = new Sparrow();
            IToyDuck toyDuck = new PlasticToyDuck();

            IToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.Fly();
            sparrow.MakeSound();

            Console.WriteLine("ToyDuck...");
            toyDuck.Squeak();

            Console.WriteLine("BirdAdapter");
            birdAdapter.Squeak();

        }

    }
}
