using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    /* https://www.geeksforgeeks.org/merge-two-sorted-linked-lists/ */
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }

    public class LinkList
    {
        Node head;
        public void AddToTheLast(Node node)
        {
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void PrintList()
        {
            Node temp = head;
            while(temp.next != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
            }
            Console.WriteLine();

        }
    }
    public class MergeTwoSortedList
    {
        public Node Merge(Node headA, Node headB)
        {
            Node dummyNode = new Node(0);

            Node tail = dummyNode;

            while(true)
            {
                if(headA == null)
                {
                    tail.next = headB;
                    break;
                }
                if(headB == null)
                {
                    tail.next = headA;
                    break;
                }

                if(headA.data < headB.data)
                {
                    tail.next = headA;
                    headA = headA.next;
                }
                else
                {
                    tail.next = headB;
                    headB = headB.next;
                }
                tail = tail.next;
            }


            return dummyNode.next;
        }
    }

}
