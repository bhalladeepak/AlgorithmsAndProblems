using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public class BreathFirstSearchUsingQueue
    {
        Node root;
        private void PrintLevelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count !=0)
            {
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.Data + " ");

                if (tempNode.Left != null)
                    queue.Enqueue(tempNode.Left);

                if (tempNode.Right != null)
                    queue.Enqueue(tempNode.Right);
            }
        }

        public void Demo()
        {
            /* creating a binary tree and entering
            the nodes */

            BreathFirstSearchUsingQueue tree_level = new BreathFirstSearchUsingQueue();
            tree_level.root = new Node(1);
            tree_level.root.Left = new Node(2);
            tree_level.root.Right = new Node(3);
            tree_level.root.Left.Left = new Node(4);
            tree_level.root.Left.Right = new Node(5);

            Console.WriteLine("Level order traversal of binary tree is - ");
            tree_level.PrintLevelOrder();
        }

    }
}
