using System;

namespace list.LinkedList.Double
{
    internal class Node
    {
        public int data;
        public Node pre;
        public Node next;
        Node() { }
        public Node(int data)
        {
            this.data = data;
        }

    }

    public class DoubleLinkedList
    {
        private Node head;
        private Node tail;
        public DoubleLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        /// <summary>
        /// Check If The List Is Empty
        /// </summary>
        public bool IsEmpty => this.head == null;
        
        /// <summary>
        /// Length Of The List
        /// </summary>
        public int Length
        {
            get
            {
                if (this.IsEmpty) return 0;
                Node tmp = this.head;
                int length = 0;
                while (tmp != null)
                {
                    length++;
                    tmp = tmp.next;
                }
                return length;
            }
        }

        /// <summary>
        /// Print All The Element Of List
        /// </summary>
        public void Print()
        {
            Node tmp = this.head;
            while(tmp != null)
            {
                Console.Write(tmp.data + " ");
                tmp = tmp.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Add An Element To The Tail Of List
        /// </summary>
        /// <param name="data"></param>
        public void AddTail(int data)
        {
            Node node = new Node(data);
            if (this.IsEmpty) {
                this.head = node;
                this.tail = node;
                node.next = node.pre = null;
            }
            else
            {
                this.tail.next = node;
                node.pre = this.tail;
                this.tail = node;
            }
        }

        /// <summary>
        /// Add An Element To The Head Of List
        /// </summary>
        /// <param name="data">Data To Add</param>
        public void AddHead(int data)
        {
            Node node = new Node(data);
            if (this.IsEmpty)
            {
                this.head = node;
                this.tail = node;
                node.next = node.pre = null;
            }
            else
            {
                node.next = this.head;
                this.head.pre = node;
                this.head = node;
            }
        }

        /// <summary>
        /// Remove The First Element Of THe List
        /// </summary>
        public void RemoveHead()
        {
            if (this.IsEmpty)
            {
                return;
            }
            else
            {
                this.head = this.head.next;
                this.head.pre = null;
            }
        }

        /// <summary>
        /// Remove The Last Element Of The List
        /// </summary>
        public void RemoveTail()
        {
            if (this.IsEmpty)
            {
                return;
            }
            else
            {
                this.tail = this.tail.pre;
                this.tail.next = null;
            }
        }
    }
}
