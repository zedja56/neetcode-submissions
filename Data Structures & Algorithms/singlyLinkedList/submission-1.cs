public class LinkedList 
{
    List<int> node = new List<int>();
    public LinkedList() 
    {

    }

    public int Get(int index) 
    {
        if (index < node.Count && index >= 0)
        {
            return node[index];
        }
        else
        {
            return -1;
        }
    }

    public void InsertHead(int val) 
    {
        node.Insert(0, val);
    }

    public void InsertTail(int val) 
    {
        node.Add(val);
    }

    public bool Remove(int index) 
    {
        if (index < node.Count && index >= 0)
        {
            node.RemoveAt(index);
            return true;
        }
        else
        {
            return false;
        }        
    }

    public List<int> GetValues() 
    {
        return node;
    }
}