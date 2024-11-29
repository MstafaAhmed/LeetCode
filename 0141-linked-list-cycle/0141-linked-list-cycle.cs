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
public class Solution {
    public bool HasCycle(ListNode head) {
        //if(head.next==null || head==null){return false;}
        var Current=head;
        var then=head;
        while(Current !=null && Current.next != null)
        {
            Current =Current.next.next;
            then = then.next;
            if(then==Current)
            {
                return true;
            }
        }
        return false;
    }
}