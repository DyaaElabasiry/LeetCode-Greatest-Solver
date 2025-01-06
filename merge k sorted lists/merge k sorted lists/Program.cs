


public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode head = null;
        ListNode currentNode = null;
        ListNode newNode;
        List<ListNode> allNodes = new List<ListNode>();
        bool finished = false;
        int? smallest = null;
        int smallestIndex = 0;
        for (int i = 0; i < lists.Length; i++)
        {
            allNodes.Add(lists[i]);
        }
        while (true)
        {
            smallest = null;
            smallestIndex = 0;
            for (int i = 0; i < allNodes.Count; i++)
            {
                if (allNodes[i] != null)
                {
                    if (smallest == null || allNodes[i].val < smallest)
                    {
                        smallest = allNodes[i].val;
                        smallestIndex = i;
                    }
                }
                else
                {
                    allNodes.RemoveAt(i);
                    i--;
                }
            }

            if (smallest != null)
            {
                newNode = new ListNode((int)smallest);
                if (head == null)
                {
                    head = newNode;
                    currentNode = head;
                }
                else
                {
                    currentNode.next = newNode;
                    currentNode = newNode;
                }

                allNodes[smallestIndex] = allNodes[smallestIndex].next;
            }
            else
            {
                break;
            }
        }

        return head;
    }
}