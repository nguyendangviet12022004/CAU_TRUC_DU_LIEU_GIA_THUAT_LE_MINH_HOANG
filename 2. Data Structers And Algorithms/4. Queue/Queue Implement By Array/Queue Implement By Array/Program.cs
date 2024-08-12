
using Queue_Implement_By_Array;

Queue qu = new Queue();

for(int i = 1;i <= 100;i ++) qu.Enqueue(i);


while (!qu.IsEmpty())
{
    Console.WriteLine(qu.Dequeue());    
}