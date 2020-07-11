using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class QueueNode
    {
        public int Data;
        public QueueNode NextNode;

        public QueueNode(int d)
        {
            Data = d;
            NextNode = null;
        }
    }
    public class Queue
    {
        private QueueNode frontNode;
        private QueueNode rearNode;
        public Queue()
        {
            frontNode = null;
            rearNode = null;
        }

        //We will add a new element to our Queue from the rear end.
        internal void Enqueue(int value)
        {
            QueueNode newNode = new QueueNode(value);

            // If queue is empty, then new node is front and rear both 
            if (this.rearNode == null)
            {
                this.frontNode = this.rearNode = newNode;
            }

            // Add the new node at the end of queue and change rear  
            else
            {
                this.rearNode.NextNode = newNode;
                this.rearNode = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", value);
        }

        //We will delete the existing element from the Queue from the front end.
        internal void Dequeue()
        {
            // If queue is empty, return NULL.  
            if (this.frontNode == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead  
            QueueNode temp = this.frontNode;
            this.frontNode = this.frontNode.NextNode;

            // If front becomes NULL, then change rear also as NULL  
            if (this.frontNode == null)
            {
                this.rearNode = null;
            }
            Console.WriteLine("Item deleted is {0}", temp.Data);
        }

    }


}
