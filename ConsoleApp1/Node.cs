using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Node
    {
        private Object value;
        public Node next;
        // constructor
        public Node(Object value)
        {
            this.value = value;
        }
        // getter and setter for value
        public Object getValue()
        {
            return value;
        }
        public void setValue(Object data)
        {
            value = data;
        }


    }
}
