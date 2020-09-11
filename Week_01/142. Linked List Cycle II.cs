/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {

        var intersect = GetIntersect(head);

        if (intersect == null) return null;

        var p1 = head;
        var p2 = intersect;

        while (p1 != p2)
        {
            p1 = p1.next;
            p2 = p2.next;
        }

        return p1;
    }

    private ListNode GetIntersect(ListNode head)
    {
        var hare = head;
        var tortoise = head;

        while (hare != null && hare.next != null)
        {
            hare = hare.next.next;
            tortoise = tortoise.next;
            if (hare == tortoise)
            {
                return hare;
            }
        }

        return null;
    }
}