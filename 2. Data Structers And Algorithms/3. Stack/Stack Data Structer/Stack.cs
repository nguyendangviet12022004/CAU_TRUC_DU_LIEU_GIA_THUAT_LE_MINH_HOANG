namespace Stack_Data_Structer
{
    internal class Stack
    {
        private LinkedList list;
        public Stack()
        {
            list = new();
        }

        public bool IsEmpty() => this.list.IsEmpty();
        public int Length() => this.list.Length();

        public void push(int value) => this.list.PushHead(value);

        public void pop() => this.list.PopHead();

        public int top() => this.list.Head();
    }
}
