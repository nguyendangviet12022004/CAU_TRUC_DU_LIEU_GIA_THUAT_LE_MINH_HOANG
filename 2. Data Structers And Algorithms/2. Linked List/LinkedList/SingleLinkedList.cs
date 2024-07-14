using System;

namespace List.LinkedList.Single

{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int data)
        {
            this.data = data;
        }

        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
    public class SingleLinkedList
    {
        private Node head;
        private Node tail;

        /// <summary>
        /// Declare An Empty Single Linked List
        /// </summary>
        public SingleLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        private Node Pre(Node node)
        {
            if (node == null || node == this.head)
            {
                return null;
            }
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.next == node)
                {
                    break;
                }
                temp = temp.next;
            }
            return temp;
        }

        /// <summary>
        /// Check and return wheather the linked list is empty or not
        /// </summary>
        /// <returns>If the linked list is empty <code>True</code> Otherwise <code>False</code></returns>
        public bool IsEmpty()
        {
            return this.head == null;
        }

        /// <summary>
        /// Clear the list
        /// </summary>
        public void Clear()
        {
            this.head = null;
            this.tail = null;
        }

        /// <summary>
        /// Add an node to the head of list
        /// </summary>
        /// <param name="data">Data to add</param>
        public void AddHead(int data)
        {
            Node node = new Node(data);
            if (this.IsEmpty())
            {
                this.head = node;
                this.tail = this.head;
            }
            else
            {
                node.next = this.head;
                this.head = node;
            }
        }

        /// <summary>
        /// Add an element to the tail of list
        /// </summary>
        /// <param name="data">Value To Add</param>
        public void AddTail(int data)
        {
            Node node = new Node(data);
            if (this.IsEmpty())
            {
                this.tail = node;
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                this.tail = node;
            }
        }

        /// <summary>
        /// Delete the first element of the list
        /// </summary>
        public void DeleteHead()
        {
            if (this.IsEmpty())
            {
                return;
            }
            else if (this.head == this.tail)
            {
                this.Clear();
            }
            else
            {
                this.head = this.head.next;
            }
        }

        /// <summary>
        /// Delete the last element of the list
        /// </summary>
        public void DeleteTail()
        {
            if (this.IsEmpty())
            {
                return;
            }
            else if (this.head == this.tail)
            {
                this.Clear();
            }
            else
            {
                Node node = this.Pre(this.tail);
                node.next = null;
                this.tail = node;
            }
        }

        /// <summary>
        /// Print To The Screen Full List Of LinkedList
        /// </summary>
        public void Print()
        {
            Node tmp = this.head;
            while (tmp != null)
            {
                Console.Write(tmp.data + " ");
                tmp = tmp.next;
            }
            Console.WriteLine();
        }

        private void Swap(Node a, Node b)
        {
            int tmp = a.data;
            a.data = b.data;
            b.data = tmp;
        }
        /// <summary>
        /// Sort the list by asc order
        /// </summary>
        public void Sort()
        {
            bool run = true;
            while (run)
            {
                run = false;
                Node tmp = this.head;
                while (tmp != null && tmp.next != null)
                {
                    if (tmp.data > tmp.next.data)
                    {
                        run = true;
                        Swap(tmp, tmp.next);
                    }
                    tmp = tmp.next;
                }
            }
        }

        /// <summary>
        /// Reverse a linked list
        /// </summary>
        public void Reverse()
        {
            Node pre = null;
            Node curr = this.head;
            while (curr != null)
            {
                Node next = curr.next;
                curr.next = pre;
                pre = curr;
                curr = next;
            }
            Node tmp = this.head;
            this.head = this.tail;
            this.tail = tmp;
        }
    }
}
