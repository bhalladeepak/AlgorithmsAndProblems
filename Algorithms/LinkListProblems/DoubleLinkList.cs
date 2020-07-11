using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    class DoubleLinkList
    {
        protected DNode header;

        public DoubleLinkList()
        {
            header = new DNode("header");
        }

        private DNode Find(object item)
        {
            DNode current = header;

            while (current.FLink != null && current.Element != item)
                current = current.FLink;
            return current;
        }

        public void Insert(object newItem, object after)
        {
            DNode newNode = new DNode(newItem);
            DNode afterNode = Find(after);

            if (afterNode != null)
            {
                if (afterNode == header)
                {
                    afterNode.FLink = newNode;
                    newNode.BLink = header;
                }
                else
                {
                    newNode.FLink = afterNode.FLink;
                    newNode.BLink = afterNode;
                    afterNode.FLink.BLink = newNode;
                    afterNode.FLink = newNode;
                }
            }
        }

        public void Remove(object itemToRemove)
        {
            DNode nodeToRemove = Find(itemToRemove);

            nodeToRemove.BLink.FLink = nodeToRemove.FLink;
            nodeToRemove.FLink.BLink = nodeToRemove.BLink;
            nodeToRemove.FLink = null;
            nodeToRemove.BLink = null;
        }

        public DNode FindLast()
        {
            DNode current = header;
            while(current.FLink != null)
                current = current.FLink;
            return current;
        }

        public void PrintReversal()
        {
            DNode current = FindLast();
            while(current.BLink != null)
            {
                Console.WriteLine(current.Element.ToString());
                current = current.BLink;
            }
        }
    }
}
