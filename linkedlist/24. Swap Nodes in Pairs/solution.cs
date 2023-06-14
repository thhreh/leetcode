public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(head == null){
            return null; 
        }
        if(head.next == null){
            return head;
        }
        
        ListNode result = SwapPairs(head.next.next);
        ListNode output = head.next;
        head.next.next = head;
        head.next = result;
        return output;
        
    }
}
