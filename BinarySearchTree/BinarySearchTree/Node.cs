using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
  /*  public class LargestBST
    {
        public Node node;
        public int maxNode;
        public int min;
        public int max;

        public LargestBST(Node n, int number, int min_value, int max_value)
        {
            node = n;
            max = max_value;
            min = min_value;
            maxNode = number;
        }
    } // end of class LargestBST
   */
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public void DisplayNode()
        {
            Console.Write(Data + " ");

        }

        public Node(int val)
        {
            this.Data = val;
            this.Left = null;
            this.Right = null;
        }
        /*
                public static int largestBSTSubtree(Node node)
                {
                    if (node == null)
                        return 0;
                    if (node.Left == null && node.Right == null)
                        return 1;

                    int LeftNode = largestBSTSubtree(node.Left);
                    int RightNode = largestBSTSubtree(node.Right);

                    if (node.Left != null && node.Right != null)
                    {
                        if ((node.Left.Data < node.Data) && (node.Right.Data > node.Data))
                        {
                            return LeftNode + RightNode + 1;
                        }
                        else if (node.Left.Data < node.Data)
                        {
                            return LeftNode + 1;
                        }
                        else if (node.Right.Data > node.Data)
                        {
                            return RightNode + 1;
                        }
                        else
                        {
                            return Math.Max(RightNode, LeftNode);
                        }
                    }
                    else if (node.Left != null)
                    {
                        if (node.Left.Data < node.Data)
                            return LeftNode + 1;
                        else
                            return LeftNode;
                    }
                    else
                    {// if (node.Right != null){
                        if (node.Data < node.Right.Data)
                            return RightNode + 1;
                        else
                            return RightNode;
                    }
                }

                public static LargestBST largestBSTSubtree1(Node node)
                {
                    if (node == null)
                        return null;
                    if (node.Left == null && node.Right == null)
                    {
                        return new LargestBST(node, 2, node.Data, node.Data);
                    }

                    LargestBST LeftNode = largestBSTSubtree1(node.Left);
                    LargestBST RightNode = largestBSTSubtree1(node.Right);

                    if (LeftNode != null && RightNode != null)
                    {
                        if ((node.Data > LeftNode.max && node.Left == LeftNode.node)
                                && (node.Data < RightNode.min && node.Right == RightNode.node))
                        {

                            LargestBST bst = new LargestBST(node,
                                    LeftNode.maxNode + RightNode.maxNode + 1,
                                    LeftNode.min,
                                    RightNode.max);

                            return bst;
                        }
                        else if (node.Data > LeftNode.max && node.Left == LeftNode.node)
                        {
                            return new LargestBST(node, LeftNode.maxNode + 1, LeftNode.min, node.Data);

                        }
                        else if (node.Data < RightNode.min && node.Right == RightNode.node)
                        {
                            return new LargestBST(node, RightNode.maxNode + 1, node.Data, RightNode.max);
                        }
                        else
                        {
                            return (LeftNode.maxNode > RightNode.maxNode) ? LeftNode : RightNode;
                        }
                    }
                    else if (LeftNode != null)
                    {
                        if (node.Data > LeftNode.max && node.Left == LeftNode.node)
                        {
                            return new LargestBST(node, LeftNode.maxNode + 1, LeftNode.min, node.Data);
                        }
                        else
                        {
                            return LeftNode;
                        }

                    }
                    else if (RightNode != null)
                    {
                        if (node.Data < RightNode.min && node.Right == RightNode.node)
                        {
                            return new LargestBST(node, RightNode.maxNode + 1, node.Data, RightNode.max);
                        }
                        else
                        {
                            return RightNode;
                        }
                    }

                    return null;
                }
         */

    }


}
