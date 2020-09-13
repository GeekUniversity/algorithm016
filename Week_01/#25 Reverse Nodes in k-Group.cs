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
    public ListNode ReverseKGroup(ListNode head, int k) 
    {
        // validate length
        int count = 0;
        var ptr = head;
        while (count < k && ptr != null) {
            ptr = ptr.next;
            ++ count;
        }
        if (count < k) return head;
        
        // reverse
        var reversedHead = this.ReverseLinkedList(head, k);
        head.next = ReverseKGroup(ptr, k);
        return reversedHead;
    }
    
    private ListNode ReverseLinkedList(ListNode head, int k) 
    {
        ListNode prev = null;
        
        while (k > 0) {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
            
            -- k;
        }
        
        return prev;
    }
}