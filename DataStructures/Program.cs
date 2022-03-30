using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            //Stack stack = new Stack(5);
            //stack.Push(10);
            //stack.Push(50);
            //stack.Push(80);
            //stack.PrintStack();
            #endregion


            #region queue
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue(30);
            //queue.Enqueue(40);

            //queue.Dequeue();
            //queue.Dequeue();
            #endregion

            #region Heap
            int[] arr1 = { 10, 64, 7, 52, 32, 18, 2, 48 };
            int[] arr2 = { 30, 5, 6, 33 };
            int n = arr1.Length;

            BinaryHeap binaryHeap = new BinaryHeap();

            BinaryHeap.MaxHeapHelper();
            BinaryHeap.MinHeapHelper();


            binaryHeap.MergeHeap(arr1, arr2);
            #endregion

            #region Trie
            Trie.Demo();
            #endregion
            Console.ReadLine();
        }
    }
}
