public class ListNode
{
    public int value;
    public ListNode next;
    public ListNode previous;

    public ListNode(int value, ListNode next = null, ListNode previous = null)
    { 
        this.value = value; 
        this.next = next; 
        this.previous = previous; 
    }
}

class Deque 
{
    ListNode head;
    ListNode tail;

    public Deque() 
    {
        head = null;
        tail = null;
    }

    public bool isEmpty() 
    {
        return head == null;
    }

    public void append(int value) 
    {
        ListNode newNode = new ListNode(value, null, tail);
        if (isEmpty()) 
        {
            head = tail = newNode;
        } 
        else 
        {
            tail.next = newNode;
            tail = newNode;
        }
    }

    public void appendleft(int value) 
    {
        ListNode newNode = new ListNode(value, head, null);
        if (isEmpty()) 
        {
            head = tail = newNode;
        } 
        else 
        {
            head.previous = newNode;
            head = newNode;
        }
    }

    public int pop() 
    {
        if (isEmpty()) return -1;

        int val = tail.value;
        tail = tail.previous;

        if (tail == null)
        {
            head = null;
        } 
        else 
        {
            tail.next = null;
        }
        return val;
    }

    public int popleft() 
    {
        if (isEmpty()) return -1;

        int val = head.value;
        head = head.next;

        if (head == null) 
        {
            tail = null;
        }
        else 
        {
            head.previous = null;
        }
        return val;
    }
}