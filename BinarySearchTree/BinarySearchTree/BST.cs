using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class BST
    {
        public Node Root;
        
        public BST()
        {
            Root = null;
        }
        

        //Find sum of all the leaf nodes in the tree 
        public int FindSumOfAlLeafNode(Node rootNode)
        {
            if (rootNode == null)
            {
                return 0;
            }
            else if (rootNode.Left == null && rootNode.Right == null)
            {
                //sum = sum + rootNode.Data;
                return rootNode.Data;
            }
            else
            {
                return FindSumOfAlLeafNode(rootNode.Left) + FindSumOfAlLeafNode(rootNode.Right);
            }
            //return sum;
        }

        public int FindNode(int key)
        {
            Node currentNode = Root;

            //if (currentNode.Data == key)
            //    return currentNode;

            while (currentNode.Data != key)
            {
                currentNode = key < currentNode.Data ? currentNode.Left : currentNode.Right;
                if (currentNode == null)
                    return 0;
            }
            currentNode.DisplayNode();
            return 1;
            //return currentNode.Data;

        }


        //public Node FindNode(int key)
        //{
        //    Node currentNode = Root;

        //    while (currentNode.Data != key)
        //    {
        //        currentNode = key < currentNode.Data ? currentNode.Left : currentNode.Right;
        //        if (currentNode == null)
        //            return null;
        //    }
        //    return currentNode;

        //}

        public Node DeleteNode(int key)
        {
            Node currentNode = Root;
            Node paretnNode = Root;
            bool isLeftChild = true;

            while(currentNode.Data != key)
            {
                paretnNode = currentNode;
                if(key < currentNode.Data)
                {
                    isLeftChild = true;
                    currentNode = currentNode.Left;
                }
                else
                {
                    isLeftChild = false;
                    currentNode = currentNode.Right;
                }
                if (currentNode == null)
                {
                    Console.Write("Error no node with the matching key found.");
                    return null; //Error no node with the matching key found
                }
            }

            //if the node to delete is a leaf node
            if ((currentNode.Left == null) && (currentNode.Right == null))
            {
                if (currentNode == Root)
                    Root = null;
                else if (isLeftChild)
                    paretnNode.Left = null;
                else
                    paretnNode.Right = null;
            }
            //if the node to delete has only right child
            else if(currentNode.Left == null)
            {
                if (currentNode == Root)
                    Root = currentNode.Right;
                else if(isLeftChild)
                    paretnNode.Left = currentNode.Right;
                else
                    paretnNode.Right = currentNode.Right;
            }
            //if the node to delete has only left child
            else if(currentNode.Right == null)
            {
                if (currentNode == Root)    //if the node to delete is the root node
                    Root = currentNode.Left;    //set the root node equal to currentNode which is the node to delete equal to currentNode.Left
                else if (isLeftChild)
                    paretnNode.Left = currentNode.Left;
                else
                    paretnNode.Right = currentNode.Left;
            }
            //Node to delete has 2 children
            else
            {
                Node successor = FindSuccessor(currentNode);
                if (currentNode == Root)
                    Root = successor;
                else if (isLeftChild)
                    paretnNode.Left = successor;
                else
                {
                    paretnNode.Right = successor;
                    successor.Left = currentNode.Left;
                }
            }
            return null;
        }

        //The success can be the right child of the node to be deleted
        //The success can be teh left most node of the right child to be deleted
        public Node FindSuccessor(Node nodeToDelete)
        {
            Node successorParent = nodeToDelete;
            Node successor = nodeToDelete;
            Node current = nodeToDelete.Right;

            while(current != null)
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }

            if(successor != nodeToDelete.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = nodeToDelete.Right;
            }
            return successor;

        }


        /*

                //The procedure InsertNode runs in O(h) time on a tree of height h.
        public void InsertNode(int nodeData) 
        {
            Node nodeToAdd = new Node(nodeData);
            nodeToAdd.Data = nodeData;

            if (Root == null)
                Root = nodeToAdd;
            else
            {
                Node currentNode = Root;
                while (true)
                {
                    Node parentNode = currentNode;
                    if (nodeData < currentNode.Data)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            parentNode.Left = nodeToAdd;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            parentNode.Right = nodeToAdd;
                            break;
                        }
                    }
                }
            }
        }


        public void PrintMaxNode(Node rootNode)
        {
            Node maxNode = FindMaxNode(rootNode);
            Console.WriteLine($"Max value : {maxNode.Data}" );
        }

        public void PrintMinNode(Node rootNode)
        {
            Node minNode = FindMinNode(rootNode);
            Console.WriteLine($"Min value : {minNode.Data}");
        }

        public Node FindMinNode(Node rootNode)
        {
            Node currentNode = rootNode;
            if (currentNode != null)
            {
                while (currentNode.Left != null)
                    currentNode = currentNode.Left;
            }
            return currentNode;
  
        }

        public Node FindMaxNode(Node rootNode)
        {
            Node currentNode = rootNode;
            if (currentNode != null)
            {
                while (currentNode.Right != null)
                    currentNode = currentNode.Right;
            }
            return currentNode;
        }

        public bool IsBST(Node node, IDictionary<Node, bool> isBST)
        {
            if (node == null)
                return true;

            bool result;
            if (!isBST.TryGetValue(node, out result))
            {
                Node maxLeft = FindMaxNode(node.Left);
                Node minRight = FindMinNode(node.Right);
                result = (maxLeft == null || maxLeft.Data <= node.Data) &&
                         (minRight == null || minRight.Data >= node.Data) &&
                         IsBST(node.Left, isBST) && IsBST(node.Right, isBST);
                isBST.Add(node, result);
            }
            return result;
        }
        


        public void InOrderTraversal(Node rootNode)
        {
            if (rootNode != null)
            {
                InOrderTraversal(rootNode.Left);
                rootNode.DisplayNode();
                InOrderTraversal(rootNode.Right);

                
            }
        }
        public void PreOrderTraversal(Node rootNode)
        {
            if(rootNode != null)
            {
                rootNode.DisplayNode();
                PreOrderTraversal(rootNode.Left);
                PreOrderTraversal(rootNode.Right);
            }

        }
        public void PostOrderTraversal(Node rootNode)
        {
            if(rootNode != null)
            {
                PostOrderTraversal(rootNode.Left);
                PostOrderTraversal(rootNode.Right);
                rootNode.DisplayNode();

            }
        }
        */

        public void LargestBST(Node bt, IDictionary<Node, bool> isBST, IDictionary<Node, int> nodeCount, ref Node largestBST)
        {
            if (bt == null)
                return;
            if (IsBST(bt, isBST) && (largestBST == null || NodeCount(bt, nodeCount) > NodeCount(largestBST, nodeCount)))
                largestBST = bt;
            else
            {
                LargestBST(bt.Left, isBST, nodeCount, ref largestBST);
                LargestBST(bt.Right, isBST, nodeCount, ref largestBST);
            }
            //return largestBST;
        }

        public int NodeCount(Node node, IDictionary<Node, int> nodeCount)
        {
            if (node == null)
                return 0;
            int result;
            if (!nodeCount.TryGetValue(node, out result))
            {
                result = 1 + NodeCount(node.Left, nodeCount) + NodeCount(node.Right, nodeCount);
                nodeCount.Add(node, result);
            }
            return result;
        }

        public int MaxDepth(Node node)
        {
            if(node == null)
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

        public void PrintLevelOrder(Node rootNode)
        {
            int depth = MaxDepth(rootNode);

            for (int i = 0; i<= depth;i++)
            {
                PrintGivenLevel(rootNode, i);
                Console.Write("\n");
            }
        }


        void PrintGivenLevel(Node node, int level)
        {
            if(node == null)
            {
                return;
            }
            if(level == 1)
            {
                node.DisplayNode();
            }
            else
            {
                PrintGivenLevel(node.Left, level - 1);
                PrintGivenLevel(node.Right, level - 1);
            }

        }
    }
}
