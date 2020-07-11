using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public abstract class AbstractClass
    {
        public void NonAbstractMethod()
        {

        }

        public abstract void AbstractMethod();

        public virtual void VirtualMethod()
        {
            Console.WriteLine("You are in base virtual method");
        }

        
    }


    public abstract class WashingMachine
    {
        public WashingMachine()
        {
            // Code to initialize the class goes here.
        }

        public abstract void Wash();
        public abstract void Rinse(int loadSize);
        public abstract void Spin(int speed);
    }

    class MyWashingMachine : WashingMachine
    {
        public MyWashingMachine()
        {
            // Initialization code goes here.    
        }

        public override void Wash()
        {
            // Wash code goes here.
        }

        public override void Rinse(int loadSize)
        {
            // Rinse code goes here.
        }

        public override void Spin(int speed)
        {
            // Spin code goes here.
        }
    }

    public class B
    {
        public virtual void Display()
        {
            Console.WriteLine("Class B's Display Method");
        }

        public virtual void DisplayNew()
        {
            Console.WriteLine("Class B's Display New Method");
        }
    }
    public class C : B
    {
        public override void Display()
        {
            Console.WriteLine("Class C's Display Method");
        }

        public new virtual void DisplayNew()
        {
            Console.WriteLine("Class C's New Display Method");
        }
    }
    public class D : C
    {
        public override void Display()
        {
            Console.WriteLine("Class D's Display Method");
        }
        public override void DisplayNew()
        {
            Console.WriteLine("Class D's New Display Method");
        }
    }


}
