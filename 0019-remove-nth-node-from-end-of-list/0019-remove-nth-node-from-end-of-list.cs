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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode newHead = new ListNode();
        newHead.next = head;
        
        ListNode prev = newHead;
        //ListNode ptr1 = head;
        ListNode ptr2 = head;
        for (int i = 0; i < n-1; i++)
        {
            ptr2 = ptr2.next;
        }

        while (ptr2.next !=null)
        {
            prev = prev.next;
            //ptr1 = ptr1.next;
            ptr2 = ptr2.next;
        }

        prev.next = prev.next.next;
        return newHead.next;
    }
}