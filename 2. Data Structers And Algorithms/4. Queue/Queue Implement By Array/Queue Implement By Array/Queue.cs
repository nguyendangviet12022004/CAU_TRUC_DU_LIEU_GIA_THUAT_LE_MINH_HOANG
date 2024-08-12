namespace Queue_Implement_By_Array
{
    internal class Queue
    {
        private int front = 0;
        private int back = -1;
        private int capacity = 10;
        private int length = 0;
        private int[] array = new int[10];

        public  Queue() { }
        public Queue(int capacity)
        {
            this.array = new int[capacity];
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public bool IsFull()
        {
            return length == capacity;
        }

        public bool Enqueue(int num)
        {
            if (this.IsFull())
            {
                return false;
            }
            this.back = (this.back + 1) % capacity;
            this.array[this.back] = num;
            this.length++;
            return true;
        }

        public int Dequeue()
        {
            if (this.IsEmpty()) return int.MaxValue;
            int frontNum = this.array[front];
            this.front = (this.front + 1) % capacity;
            this.length--;
            return frontNum;
        }

    }
}
