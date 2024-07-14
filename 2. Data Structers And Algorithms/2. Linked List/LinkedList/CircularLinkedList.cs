using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.LinkedList.Circular
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    internal class CircularLinkedList
    {
        private Node head;
        private Node tail;

        public CircularLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }
        /// <summary>
        /// Add A Data To The Tail Of List
        /// </summary>
        /// <param name="data">Data</param>
        public void AddTail(int data)
        {
            Node node = new Node(data);
            if (IsEmpty())
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                this.tail.next = node;
                this.tail = node;
            }
            this.tail.next = this.head;
        }

        /// <summary>
        /// Add A Data To The Head Of List
        /// </summary>
        /// <param name="data">Data</param>
        public void AddHead(int data) { 
            Node node = new Node(data);
            if (IsEmpty())
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                node.next = this.head;
                this.head = node;
            }
            this.tail.next = this.head;
        }

        /// <summary>
        /// Print The List
        /// </summary>
        public void print()
        {
            if (IsEmpty())
            {
                return;
            }
            Node tmp = this.head;
            while(tmp != this.tail)
            {
                Console.Write(tmp.data);
                tmp = tmp.next;
            }
            Console.WriteLine(this.tail.data);

        }
    }
}
