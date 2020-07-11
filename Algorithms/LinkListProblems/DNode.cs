using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    class DNode
    {
        public object Element;
        public DNode FLink;
        public DNode BLink;

        public DNode()
        {
            Element = null;
            FLink = null;
            BLink = null;
        }
        public DNode(object theElement)
        {
            Element = theElement;
            FLink = null;
            BLink = null;
        }

    }
}
