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
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode newHead = new ListNode();
        newHead.next = head;
        ListNode prev = newHead;

        ListNode ptr;
        int currentValue;
        while (prev.next is not null)
        {
            ptr = prev.next;
            currentValue = ptr.val;
            if (ptr.next is not null && ptr.next.val == currentValue)
            {
                ptr = ptr.next;
                while (ptr is not null && ptr.val == currentValue)
                {
                    ptr = ptr.next;
                }

                prev.next = ptr;
            }
            else 
            {
                prev = prev.next;
            }
        }

        return newHead.next;
    }
}