public class Solution {
    public ListNode OddEvenList(ListNode head) {
    if (head == null)
    {
        return null;
    }
    ListNode dummy = new ListNode(-1);
    ListNode output = head;
    ListNode origin_dummy = dummy;
    while (head.next != null && head.next.next != null)
    {
        dummy.next = head.next;
        dummy = dummy.next;
        head.next = head.next.next;
        head = head.next;
    }

    if (head.next == null)
    {
        dummy.next = null;
        head.next = origin_dummy.next;
    }

    else if (head.next.next == null)
    {
        dummy.next = head.next;
        dummy.next.next = null;
        head.next = origin_dummy.next;
    } 
    return output;

}
}
