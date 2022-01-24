using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LinkedList
    {
        private Node firstElement;
        private int length;
        // getter for length
        public int getLength()
        {
            return length;
        }
        // constructor
        public LinkedList()
        {
            length = 0;
            firstElement = null;
        }
        // print all nodes in the list
        public void printAll()
        {
            Node x = firstElement;

            while (x != null)
            {

                Console.WriteLine(x.getValue());

                x = x.next;
            }

        }
        // add new node to the end of the list 
        public void addToEnd(Object data)
        {
            Node a = new Node(data);
            Node x = firstElement;
            if (x == null) firstElement = a;
            else
            {
                while (x.next != null)
                {
                    x = x.next;
                }
                x.next = a;
            }
            length += 1;

        }
        public void addToStart(Object data)
        {
            Node x = new Node(data);
            x.next = firstElement;
            firstElement = x;
        }
        // delete node from list using data
        public void delete(Object data)
        {
            Node x = firstElement;
            if (x != null)
            {
                if (x.getValue() == data)
                {
                    if (x.next != null) x = x.next;
                    else x = null;
                    firstElement = x;
                    length -= 1;
                    return;
                }
            }
            while (x.next != null && x.next.getValue() != data)
            {
                x = x.next;
            }
            if (x.next != null && x.next.getValue() == data)
            {
                x.next = x.next.next;
                x = null;
                length -= 1;
            } else
            {
                Console.WriteLine("Data not found");
            }
        }
        // get node by position in list
        public Node getByIndex(int index)
        {
            Node x = firstElement;
            if (index == 0)
            {
                return x;
            }
            if (x != null)
            {
                int i = 0;
                while (x.next != null && i <= index)
                {
                    x = x.next;
                    i++;
                }
                return x;
            }
            else throw new Exception("List empty");
        }
    
    }
}
