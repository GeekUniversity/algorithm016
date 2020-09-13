﻿/**
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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        // check length
        int count = 0;
        var ptr = head;
        while (count < k && ptr != null)
        {
            ptr = ptr.next;
            ++count;
        }

        if (count < k) return head;

        var reversedHead = this.ReverseLinkedList(head, k);
        head.next = ReverseKGroup(ptr, k);
        return reversedHead;
    }

    private ListNode ReverseLinkedList(ListNode head, int k)
    {
        ListNode prev = null;
        ListNode curr = head;
        ListNode next = null;

        while (k > 0)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;

            --k;
        }

        return prev;
    }
}