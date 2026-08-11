/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode node1 = list1;
        ListNode node2 = list2;
        ListNode dummy = new ListNode(0);
        ListNode currentNode = dummy;

        while(node2 != null && node1 != null)
        {
            if(node1.val <= node2.val)
            {
                currentNode.next = node1;
                node1 = node1.next;
            }
            else
            {
                currentNode.next = node2;
                node2 = node2.next;
            }
            currentNode = currentNode.next;
        }
        if (node1 != null)
        {
            currentNode.next = node1;
        }
        else if (node2 != null)
        {
            currentNode.next = node2;
        }

        return dummy.next;
    }
}