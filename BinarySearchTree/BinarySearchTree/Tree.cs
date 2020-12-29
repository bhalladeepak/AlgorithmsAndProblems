using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{

    /*

    //Check if the tree is binary
    https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/

    
    Depth First Traversals:
        (a) Inorder (Left, Root, Right) : 4 2 5 1 3
        (b) Preorder (Root, Left, Right) : 1 2 4 5 3
        (c) Postorder (Left, Right, Root) : 4 5 2 3 1

        InOrder Traversals(Left, Root, Right) : 4 10 12 15 18 22 24 25 31 35 44 50 66 70 90
        PreOrder Traversals(Root, Left, Right) : 25 15 10 4 12 22 18 24 50 35 31 44 70 66 90
        PostOrder Traversals(Left, Right, Root) : 4 12 10 18 24 22 15 31 44 35 66 90 70 50 25
    https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
     *
     *
     */

    public class Tree
    {
        public Node Root;


        public static void TreeMergeExample()
        {

        }


        //InsertNode
        public void InsertNode(int data)
        {
            Node newNode = new Node(data);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node currentNode = Root;
                while (true)
                {
                    Node parentNode = currentNode;
                    if (parentNode.Data < data)
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            parentNode.Right = newNode;
                            break;
                        }
                    }

                    if (parentNode.Data > data)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            parentNode.Left = newNode;
                            break;
                        }
                    }

                }

            }

        }



        //FindMinNode	
        private Node FindMinNode(Node rootNode)
        {
            Node currentNode = rootNode;

            while (currentNode.Left != null)
                currentNode = currentNode.Left;

            return currentNode;
        }

        //FindMaxNode
        private Node FindMaxNode(Node rootNode)
        {
            Node currentNode = rootNode;

            while (currentNode.Right != null)
                currentNode = currentNode.Right;

            return currentNode;
        }

        public void IsBst()
        {
            Node min = FindMinNode(Root);
            Node max = FindMaxNode(Root);

            bool isBst = IsBstUtil(Root, min.Data, max.Data);

            Console.WriteLine($"BST tree valid : {isBst}");
        }

        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                node.DisplayNode();
                InOrderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal(Node node)
        {
            if (node != null)
            {
                node.DisplayNode();
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal(Node node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                node.DisplayNode();
            }
        }

        //Check if the tree is BinaryTree
        private bool IsBstUtil(Node node, int minData, int maxData)
        {
            if (node == null)
                return true;

            if (node.Data <= minData)
                return false;

            if (node.Data >= maxData)
                return false;

            return (IsBstUtil(node.Left, minData, node.Data) && IsBstUtil(node.Right, node.Data, maxData));

        }



        //Print node at each level
        public void PrintGivenLevel(Node node, int level)
        {
            if (node == null)
            {
                return;
            }
            if (level == 1)
            {
                node.DisplayNode();
            }
            else
            {
                PrintGivenLevel(node.Left, level - 1);
                PrintGivenLevel(node.Right, level - 1);
            }
        }


        //Find maximum depth of the tree
        public int MaxDepth(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int lDepth = MaxDepth(node.Left);
                int rDepth = MaxDepth(node.Right);

                if (lDepth > rDepth)
                    return lDepth + 1;
                else
                    return rDepth + 1;
            }
        }
    }
}
