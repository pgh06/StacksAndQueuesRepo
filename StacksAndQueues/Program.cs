using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Head { get; set; }
        public int Size { get; internal set; }

        public class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public Node(object data)
            {
                Data = data;
            }
        }

        internal void Push(object data)
        {
            Node newNode = new Node(data);

            newNode.Next = Head;
            Head = newNode;
        }

        internal void Pop()
        {
            object data = Head.Data;
            Head = Head.Next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            // add head
            stack.Push(1);

            // add node to replace head
            stack.Push(2);

            // remove top
            stack.Pop();

            // remove last
            stack.Pop();
        }
    }
}