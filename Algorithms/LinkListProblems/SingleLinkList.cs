using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LinkListProblems
{
    public class SingleLinkList
    {
        private SNode Header;
        private static int count;
        public SingleLinkList()
        {
            Header = null;
        }

        #region Insert operations
       
        public void InsertFront(object data)
        {
            SNode newNode = new SNode(data);
            if(Header == null)
            {
                Header = newNode;
                return;
            }
            newNode.Next = Header.Next;
            this.Header.Next = newNode;
        }

        public void InsertAfter(object newItem, object after)
        {
            SNode current = Find(after);
            SNode newNode = new SNode(newItem);

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void InsertLast(object data)
        {
            SNode newNode = new SNode(data);
            if (Header == null)
            {
                Header = newNode;
                return;
            }
            SNode lastNode = FindLast();
            lastNode.Next = newNode;
        }
        
        #endregion


        #region Find operations
        public SNode Find(object item)
        {
            SNode current = Header;

            while (current.Next != null && current.Element != item)
                current = current.Next;
            return current;
        }

        private SNode FindPrevious(object item)
        {
            SNode current = new SNode();
            current = Header;

            while (current.Next != null && current.Next.Element != item)
                current = current.Next;
            return current;
        }

        private SNode FindLast()
        {
            SNode currentNode = Header;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        #endregion


        public void Remove(object deleteItem)
        {
            SNode previous = FindPrevious(deleteItem);
            SNode current = Find(deleteItem);
            if (previous.Next != null)
                previous.Next = current.Next;
        }

        public void PrintLinkList()
        {
            SNode current = new SNode();
            current = Header;
            while(current != null)
            {
                Console.Write(current.Element.ToString() + " ");
                current = current.Next;
            }
        }

        public SNode Reverse()
        {
            SNode current = Header;
            SNode previous = null;
            SNode next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            Header = previous;
            return previous;
        }

        public void PrintLastNNodes(SNode node, int n)
        {
            if (node == null)
                return;
            //use a static varaible to keep track of the count in the recursive method
            count = n;
            PrintLastNNodes(node.Next, n);

            if (count  > 0)
            {
                Console.Write(node.Element.ToString() + " ");
                count--;
            }
        }

        public void PrintLastNNodesUtility(int n)
        {
            SNode header = Header;

            PrintLastNNodes(header, n);
        }

    }
}
