public class Solution {
     public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    Stack<int> stk1 = new Stack<int>();
    Stack<int> stk2 = new Stack<int>();

    while (l1 != null)
    {
        stk1.Push(l1.val);
        l1 = l1.next;
    }
    while (l2 != null)
    {
        stk2.Push(l2.val);
        l2 = l2.next;
    }

    ListNode Dummy = new ListNode(-1);
    int carryOver = 0;
    while (stk1.Count != 0
        || stk2.Count != 0
        || carryOver > 0)
    {
        int val = carryOver;
        if (stk1.Count != 0)
        {
            val += stk1.Pop();
        }
        if (stk2.Count != 0)
        {
            val += stk2.Pop();
        }
        carryOver = val / 10;
        val = val % 10;

        ListNode newNode = new ListNode(val);
        newNode.next = Dummy.next;
        Dummy.next = newNode;

    }
    return Dummy.next;
}
}
