using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkListDemo();


            Console.ReadLine();
        }

        private static void SinglyLinkListDemo()
        {
            //InsertFront
            //InsertLast
            //InsertAfter
            //Print
            //Remove
            //Reverse
            //Print last N


            SingleLinkList sLinkList = new SingleLinkList();
            sLinkList.InsertFront("1");
            sLinkList.InsertLast("2");
            sLinkList.InsertLast("3");
            sLinkList.InsertFront("22");
            sLinkList.InsertAfter("77", "1");


            sLinkList.PrintLinkList();

            Console.WriteLine();
            sLinkList.Remove("22");
            Console.WriteLine("Remove 22 from the list");


            sLinkList.PrintLinkList();
            Console.WriteLine();
            Console.WriteLine("Reverse Link list-----------------------------");
            sLinkList.Reverse();
            sLinkList.PrintLinkList();


            Console.WriteLine();
            Console.WriteLine("Print last 2-----------------------------");
            sLinkList.PrintLastNNodesUtility(2);

            Console.ReadLine();
        }
    }
}
