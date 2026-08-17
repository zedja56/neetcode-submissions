public class ListNode
{
    public ListNode next;
    public ListNode previous;
    public int val;

    public ListNode(int value, ListNode next = null, ListNode previous = null)
    {
        val = value;
        this.previous = previous;
        this.next = next;
    }
}
public class MyLinkedList 
{
    ListNode head;
    ListNode tail;

    public MyLinkedList() 
    {
        head = new ListNode(0);
        tail = new ListNode(0);
        head.next = tail;
        tail.previous = head;
    }
    
    public int Get(int index) 
    {
        ListNode current = head.next;
        while(current != null && index > 0)
        {
            current = current.next;
            index --;
        }
        if (current != null && current != tail && index == 0)
        {
            return current.val;
        }
        return -1;
    }
    
    public void AddAtHead(int val) 
    {
        ListNode newNode = new ListNode(val);
        ListNode nextNode = head.next;
        ListNode previousNode = head;
        previousNode.next = newNode;
        nextNode.previous = newNode;
        newNode.next = nextNode;
        newNode.previous = previousNode;
    }
    
    public void AddAtTail(int val) 
    {
        ListNode newNode = new ListNode(val);
        ListNode nextNode = tail;
        ListNode previousNode = tail.previous;
        previousNode.next = newNode;
        nextNode.previous = newNode;
        newNode.next = nextNode;
        newNode.previous = previousNode;    
    }
    
    public void AddAtIndex(int index, int val) 
    {
        ListNode current = head.next;
        while (current != null && index > 0)
        {
            current = current.next;
            index--;
        }
        if (current != null && index == 0)
        {
            ListNode newNode = new ListNode(val);
            ListNode nextNode = current;
            ListNode previousNode = current.previous;
            previousNode.next = newNode;
            nextNode.previous = newNode;
            newNode.next = nextNode;
            newNode.previous = previousNode;    
        }
    }
    
    public void DeleteAtIndex(int index) 
    {
        ListNode current = head.next;
        while (current != null && index > 0)
        {
            current = current.next;
            index--;
        }
        if (current != null && current != tail && index == 0)
        {
            ListNode nextNode = current.next;
            ListNode previousNode = current.previous;
            nextNode.previous = previousNode;
            previousNode.next = nextNode;
        }
    }
}


/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */