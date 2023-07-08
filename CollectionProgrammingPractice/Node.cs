using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgrammingPractice
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int Ndata)
        {
            this.data = Ndata;
            this.next = null;
        }
    }
}
