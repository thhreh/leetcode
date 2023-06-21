public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null){
            return false;
        }
        Stack<int> temp= new Stack<int>();
        ListNode old_head = head;
        while(head != null){
            temp.Push(head.val);
            head = head.next;
        }
        while(old_head != null){
            if(temp.Pop()!= old_head.val){
                return false;
            }
            old_head = old_head.next;
        }
        return true;


        
    }
}
