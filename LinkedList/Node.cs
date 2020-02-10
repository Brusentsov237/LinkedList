using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        Node next;
        int value;
        int index;
        public Node(int val)
        {
            value = val;
        }
        public Node Next { get; set; }
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
    }
}
