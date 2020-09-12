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
        var prev2 = new ListNode();

        while (head != null)
        {
            var temp2 = prev2.next;
            var temp1 = head.next;

            prev2.next = head;
            head = head.next;

            prev2.next.next = temp2;
            head = temp1;
        }

        return prev2.next;
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