/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode r = new ListNode(0);
        var n = r;
        ListNode n1;
        int inc = 0;
        do
        {
            n.val += inc;
            inc = 0;
            if(l1 != null)
            {    
                n.val += l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                n.val += l2.val;
                
                l2 = l2.next;
            }
            if(n.val >= 10)
            {
                n.val -= 10;
                inc = 1;
            }
            n.next = new ListNode(0);
            n1 = n;
            n = n.next;
        }while(l1 != null || l2 != null);
        
        if(inc == 1)
            n.val = 1;
        else
            n1.next = null;
        
        return r;
        
    }
}