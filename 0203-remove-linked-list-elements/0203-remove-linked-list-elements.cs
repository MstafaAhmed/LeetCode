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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head==null){return null;}
       
        ListNode ans=new ListNode(-1);
        ans.next=head;
        var prev =ans;
       
        while(prev.next!=null)
        {
            if(prev.next.val==val)
            {
                prev.next=prev.next.next;

            }else{
            prev=prev.next;}
        }
        return ans.next;
    }
}