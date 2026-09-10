public class MyStack 
{
    Queue<int> queue1;

    public MyStack() 
    {
        queue1 = new();
    }
    
    public void Push(int x) 
    {
        queue1.Enqueue(x);
    }
    
    public int Pop() 
    {
        for (int i=0; i < queue1.Count-1; i++)
        {
            queue1.Enqueue(queue1.Dequeue());
        }
        return queue1.Dequeue();
    }
    
    public int Top() 
    {
        for (int i=0; i < queue1.Count-1; i++)
        {
            queue1.Enqueue(queue1.Dequeue());
        }
        int top = queue1.Dequeue();
        queue1.Enqueue(top);
        return top;
    }
    
    public bool Empty() 
    {
        return queue1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */