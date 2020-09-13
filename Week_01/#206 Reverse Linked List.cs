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

// iterative
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;

        while (head != null)
        {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }
}

// recursive
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        var next = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return next;
    }
}