using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    //In the .NET Framework Library, the ArrayList data structure is implemented
    //using a circularly linked list. There are also many problems that can
    //be solved using a circularly linked list.
    class CircularlyLinkedList
    {
        protected SNode current;
        protected SNode header;
        private int count;

        public CircularlyLinkedList() 
        {
            count = 0;
            header = new SNode("header");
            header.Next = header;
        }

        public bool IsEmpty() 
        {
            return (header.Next == null);
        }
        public void MakeEmpty() 
        {
            header.Next = null;
        }
        public void PrintList() 
        {
            SNode current = new SNode();
            current = header;
            while (!(current.Next.Element == "header")) 
            {
                Console.WriteLine(current.Next.Element);
                current = current.Next;
            }
        }
        private SNode FindPrevious(Object n)
        {
            SNode current = header;
            while (!(current.Next == null) && current.Next.Element != n)
                current = current.Next;
            return current;
        }
        private SNode Find(Object n)
        {
            SNode current = new SNode();
            current = header.Next;
            while (current.Element != n)
                current = current.Next;
            return current;
        }
        public void Remove(Object n)
        {
            SNode p = FindPrevious(n);
            if (!(p.Next == null))
                p.Next = p.Next.Next;
            count--;
        }

        public void Insert(object n1, object n2) 
        {
            SNode current = new SNode();
            SNode newnode = new SNode(n1);
            current = Find(n2);
            newnode.Next = current.Next;
            current.Next = newnode;
            count++;
        }

        public void InsertFirst(object n) 
        {
            SNode current = new SNode(n);
            current.Next = header;
            header.Next = current;
            count++;
        }
        
        public SNode Move(int n) 
        {
            SNode current = header.Next;
            SNode temp;
            for (int i = 0; i <= n; i++)
            {
                current = current.Next;
            }
            if (current.Element == "header")
                current = current.Next;
            temp = current;
            return temp;
         }

    }
}
