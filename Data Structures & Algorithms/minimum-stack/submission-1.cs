public class MinStack 
{
    Stack<int> stack = new Stack<int>();
    Stack<int> minStack = new Stack<int>();
    int minValue;

    public MinStack() 
    {
    }
    
    public void Push(int val) 
    {
        if(minStack.Count != 0)
        {
            minValue = minStack.Peek();
        }
        if(stack.Count == 0 || minValue >= val)
        {
            minStack.Push(val);
        }
        stack.Push(val);
    }
    
    public void Pop() 
    {
        int value = stack.Pop();
        if(minStack.Count != 0)
        {
            minValue = minStack.Peek();
        }
        Console.WriteLine(minValue + " " + value);

        if(minValue == value)
        {
            // Console.WriteLine(minValue + " " + value);
            minStack.Pop();
        }    
    }
    
    public int Top() 
    {
        return stack.Peek();
    }
    
    public int GetMin() 
    {
        return minStack.Peek();   
    }
}
