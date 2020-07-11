using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack
    {
        private int[] elements;
        private int top;
        private int max;

        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                elements[top] = item;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack : " + elements[top]);
                top--;
                return elements[top];
            }
        }

        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(elements[i] + " pushed into stack");
                }
            }
        }
    }
}
