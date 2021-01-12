using System;
using System.Collections.Generic;

namespace StackConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generik Stack Class Operations");

            // Stack Generic Call in C#
            Stack<int> testStack = new Stack<int>();
            int count = 0;

            Console.WriteLine("Enter how many element for stack");
            var inputCount = Console.ReadLine();

            if(Int32.TryParse(inputCount, out count))
            {
                for(int i = 0; i < count; i++)
                {
                    testStack.Push(Convert.ToInt32(Console.ReadLine()));
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Total Element in Stack is {testStack.Count}");
            Console.WriteLine($"Top Element on Stack is {testStack.Peek()} - Peek Operation");            
            
            while(testStack.Count > 0)
            {
                Console.WriteLine($"Element in Stack is : {testStack.Pop()} - Pop Operation");
            }

            // Stack with linked list
            StackLinkedList stackLinkedList = new StackLinkedList();

            Console.WriteLine();

            Console.WriteLine("Enter how many element for stack");
            var inputStackCount = Console.ReadLine();

            if (Int32.TryParse(inputStackCount, out count))
            {
                for (int i = 0; i < count; i++)
                {
                    stackLinkedList.PUSH(Convert.ToInt32(Console.ReadLine()));
                }
            }
            Console.WriteLine($"Top Element on Stack is {stackLinkedList.PeeK()} - Peek Operation");

            while (stackLinkedList.top != null)
            {
                Console.WriteLine($"Element in Stack is : {stackLinkedList.POP()} - Pop Operation");
            }


        }
    }
}
