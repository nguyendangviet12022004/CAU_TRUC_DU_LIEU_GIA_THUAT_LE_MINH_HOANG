using System.Numerics;

namespace Stack_Data_Structer
{
    class Node
    {
        internal int value;
        internal Node next = null;
        public Node() {}
        public Node(int value) { this.value = value; }
    }
    internal class LinkedList
    {
        private Node head = null;
        private int length;

        public LinkedList()
        {
        }

        public bool IsEmpty() => this.length == 0 || this.head == null;
        public int Length() => this.length;
        public void PushHead(int value)
        {
            Node node = new Node(value);
            if (length == 0)
            {
                this.head = node;

            }
            else
            {
                node.next = this.head;
                this.head = node;
            }
            this.length++;
        }
        public void PopHead()
        {
            if (length == 0)
            {
                return;
            }
            else
            {
                this.head = this.head.next;
            }
            this.length--;
        }
        public int Head()
        {
            if(this.head == null)
            {
                return int.MinValue;
            }else
            {
                return this.head.value;
            }
        }

    }
}
