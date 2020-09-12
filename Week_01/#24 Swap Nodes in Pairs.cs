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
    public ListNode SwapPairs(ListNode head)
    {
        var prehead = new ListNode(0, head);
        var prev = prehead;

        while (head != null && head.next != null)
        {
            var first = head;
            var second = head.next;

            prev.next = second;
            first.next = second.next;
            second.next = first;

            prev = first;
            head = first.next;
        }

        return prehead.next;
    }
}
