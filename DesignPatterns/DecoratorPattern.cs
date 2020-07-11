using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //https://www.geeksforgeeks.org/decorator-pattern/
    interface IPizza
    {
        string GetDescription();
    }
    abstract class Pizza : IPizza
    {
        public string Description { get; set; }

        protected Pizza()
        {
            Description = "Unknown Pizza";
        }
        
        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract int GetCost();
    }

    interface IToppingsDecorator : IPizza
    {
        string GetDescription();
    }

    #region Concrete pizza classes
    class PeppyPaneer : Pizza
    {
        public PeppyPaneer()
        {
            Description = "PeppyPaneer";
        }

        public override int GetCost()
        {
            return 100;
        }
    }

    class FarmHouse : Pizza
    {
        public FarmHouse()
        {
            Description = "FarmHouse ";
        }
        public override int GetCost()
        {
            return 200;
        }
    }

    class Margherita : Pizza
    {
        public Margherita()
        {
            Description = "Margherita";
        }

        public override int GetCost()
        {
            return 100;
        }
    }


    class ChickenFiesta : Pizza
    {
        public ChickenFiesta()
        {
            Description = "ChickenFiesta ";
        }

        public override int GetCost()
        {
            return 200;
        }
    }

    class SimplePizza : Pizza
    {
        public SimplePizza()
        {
            Description = "SimplePizza ";
        }

        public override int GetCost()
        {
            return 50;
        }
    }


    #endregion

    #region Concrete toppings classes
    class FreshTomato : Pizza, IToppingsDecorator
    {
        // we need a reference to obj we are decorating 
        readonly Pizza _pizza;

        public FreshTomato(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Fresh Tomato ";
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 40;
        }
    }

    class Barbeque : Pizza, IToppingsDecorator
    {
        private readonly Pizza _pizza;

        public Barbeque(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Barbeque";
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 90;
        }
    }
    #endregion




    public class DecoratorPattern
    {
        public static void DecoratorExample()
        {
            Pizza peppyPaneer = new PeppyPaneer();

            Console.WriteLine(peppyPaneer.GetDescription() + " Cost : " + peppyPaneer.GetCost());

            peppyPaneer = new FreshTomato(peppyPaneer);
            peppyPaneer = new Barbeque(peppyPaneer);

            Console.WriteLine(peppyPaneer.GetDescription() + " Cost : " + peppyPaneer.GetCost());

        }

    }
}
