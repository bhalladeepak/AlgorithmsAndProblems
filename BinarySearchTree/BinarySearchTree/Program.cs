﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bstObject = new BST();
            bstObject.InsertNode(23);
            bstObject.InsertNode(45);
            bstObject.InsertNode(16);
            bstObject.InsertNode(37);
            bstObject.InsertNode(3);
            bstObject.InsertNode(17);
            bstObject.InsertNode(99);
            bstObject.InsertNode(90);
            bstObject.InsertNode(30);


            //Console.Write("Find Minimum: ");
            //bstObject.FindMinimumNode(bstObject.Root);


            //////////////Console.Write("\n\n");
            //////////////Console.Write("Find Maximum: ");
            //////////////bstObject.FindMaxNode(bstObject.Root);


            ////////////////Console.Write("\n\n");
            ////////////////Console.Write("Inorder Traversal : ");
            ////////////////bstObject.InOrderTraversal(bstObject.Root);

            Console.Write("\n\n");
            Console.Write("Height or Depth of the tree : ");
            Console.WriteLine(bstObject.MaxDepth(bstObject.Root));

            bstObject.PrintLevelOrder(bstObject.Root);

            //////////////Console.Write("\n\n");
            //////////////Console.Write("Pre Order Traversal : ");
            //////////////bstObject.PreOrderTraversal(bstObject.Root);


            //////////////Console.Write("\n\n");
            //////////////Console.Write("Post Order Traversal : ");
            //////////////bstObject.PostOrderTraversal(bstObject.Root);


            //////////////Console.Write("\n\n");
            //////////////Console.Write("Finding Node : ");
            //////////////bstObject.FindNode(99);


            Console.Write("\n\n");
            Console.Write("Finding Sum of all the nodes : ");
            //Console.Write(bstObject.FindSumOfAlLeafNode(bstObject.Root));


            //IDictionary<Node, bool> isBST = new SortedList<Node, bool>();
            //IDictionary<Node, int> nodeCount = new SortedList<Node, int>();
            //Node largestBST = null;
            
            //Console.Write("\n\n");
            ////Console.Write(bstObject.NodeCount(bstObject.Root,));
            //bstObject.LargestBST(bstObject.Root, isBST, nodeCount, ref largestBST);
            
            ////bstObject.NodeCount(bstObject.Root, nodeCount);

            ////bstObject.InOrderTraversal(bstObject.Root);

            //Console.Write("End");
            //Console.ReadLine();

        ////////int result = Node.largestBSTSubtree(bstObject.Root);
        ////////Console.Write("largest bst (may not include all children): " + result);

        ////////LargestBST largeBST = Node.largestBSTSubtree1(bstObject.Root);
        ////////if (largeBST != null)
        ////////    Console.Write(largeBST.node.Data + " : size " + largeBST.maxNode);





            LargestBSTSubtree b = new LargestBSTSubtree();
            int result =  b.largestBSTSubtree(bstObject.Root);
            Console.Write("largest bst (may not include all children): " + result);

            //int largeBST = b.largestBSTSubtree1(bstObject.Root);
            //if (largeBST != null)
            //    Console.Write(largeBST.node.Data + " : size " + largeBST.maxNode);

            //LargestBST largeBST2 = LargestBSTSubtree(bstObject.Root);
            //if (largeBST2 != null)
            //    Console.Write(largeBST2.node.Data + " : size " + largeBST2.maxNode);


        }
    }
}
