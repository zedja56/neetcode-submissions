public class ListNode
{
    public string url;
    public ListNode next;
    public ListNode previous;

    public ListNode (string url, ListNode next = null, ListNode previous = null)
    {
        this.url = url;
        this.next = next;
        this.previous = previous;
    }
}
public class BrowserHistory 
{
    ListNode current;

    public BrowserHistory(string homepage) 
    {
        current = new ListNode(homepage);
    }
    
    public void Visit(string url) 
    {
        current.next = new ListNode(url, null, current);
        current = current.next;

    }
    
    public string Back(int steps) 
    {
        while(current.previous != null && steps > 0)
        {
            current = current.previous;
            steps--;
        }
        return current.url;    
    }
    
    public string Forward(int steps) 
    {
        while(current.next != null && steps > 0)
        {
            current = current.next;
            steps--;
        }
        return current.url;   
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */