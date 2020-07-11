using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    public class SNode
    {
        internal object Element;
        internal SNode Next;

        public SNode()
        {
            Element = null;
            Next = null;
        }

        public SNode(object theElement)
        {
            Element = theElement;
            Next = null;
        }
    }
}
