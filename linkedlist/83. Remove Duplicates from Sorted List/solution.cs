public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        ListNode output = head;
        while(head.next != null){
            if (head.next.val == head.val){
                if(head.next.next == null){
                    head.next = null;
                }
                else{
                    head.next = head.next.next;
                    if(head.val != head.next.val){
                        head = head.next;
                    }
                }
            }
            else{
                head = head.next;
            }
            
            
        }
        return output;
    }
}
