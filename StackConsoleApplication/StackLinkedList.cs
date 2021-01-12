using System;
using System.Collections.Generic;
using System.Text;

namespace StackConsoleApplication
{
    public class Node
    {
        public int data;
        public Node link;
    }

    public class StackLinkedList
    {
        public Node top;

        public StackLinkedList()
        {
            this.top = null;
        }

        public void PUSH(int x)
        {
            Node node = new Node();

            node.data = x;
            node.link = top;

            top = node;
        }

        public int PeeK()
        {
            if(top != null)
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }

        public int POP()
        {
            if(top != null)
            {
                int data = top.data;
                top = top.link;
                return data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }
    }
}
