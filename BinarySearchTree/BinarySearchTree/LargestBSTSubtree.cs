using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public class LargestBSTSubtree
    {

        public class LargestBST
        {
            public Node node;
            public int maxNode;
            public int min;
            public int max;

            public LargestBST(Node n, int number, int min_Data, int max_Data)
            {
                node = n;
                max = max_Data;
                min = min_Data;
                maxNode = number;
            }
        } // end of class LargestBST

    //    public static void main(String[] args) {
    //    Node root = new Node(10);
    //    Node node5 = new Node(5);
    //    Node node15 = new Node(15);
    //    Node node6 = new Node(6);
    //    Node node7 = new Node(7);
    //    node15.Right = node7;
    //    Node node3 = new Node(3);
    //    Node node12 = new Node(12);
    //    Node node11 = new Node(11);
    //    Node node13 = new Node(13);
    //    Node node14 = new Node(14);

    //    root.insert(node5);
    //    root.insert(node6);
    //    root.insert(node15);
    //    root.insert(node3);
    //    root.insert(node12);
    //    root.insert(node11);
    //    root.insert(node13);
    //    root.insert(node14);

    //    int result = largestBSTSubtree(root);
    //    System.out.println("largest bst (may not include all children): " + result);

    //    LargestBST largeBST = largestBSTSubtree1(root);
    //    if (largeBST != null)
    //        System.out.println(largeBST.node.Data + " : size " + largeBST.maxNode);

    //    LargestBST largeBST2 = largestBSTSubtree2(root);
    //    if (largeBST2 != null)
    //        System.out.println(largeBST2.node.Data + " : size " + largeBST2.maxNode);
    //}

        // Given a binary tree, find the largest Binary Search Tree (BST),
        // where largest means BST with largest number of nodes in it.
        // The largest BST may or may not include all of its descendants.
        public int largestBSTSubtree(Node node)
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

        // Given a binary tree, find the largest Binary Search Tree (BST),
        // where largest means BST with largest number of nodes in it.
        // The largest BST may or may not include all of its descendants.
        public LargestBST largestBSTSubtree1(Node node)
        {
            if (node == null)
                return null;
            if (node.Left == null && node.Right == null)
            {
                return new LargestBST(node, node.GetHashCode(), node.Data, node.Data);
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

        // Given a binary tree, find the largest Binary Search Tree (BST),
        // where largest means BST with largest number of nodes in it.
        // The largest BST must include all of its descendants.
        public LargestBST largestBSTSubtree2(Node node)
        {
            if (node == null)
                return null;
            if (node.Left == null && node.Right == null)
            {
                return new LargestBST(node, node.GetHashCode(), node.Data, node.Data);
            }

            LargestBST LeftNode = largestBSTSubtree2(node.Left);
            LargestBST RightNode = largestBSTSubtree2(node.Right);

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


    }
}
