
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int r = l1.val + l2.val;
        if (r >= 10)
            if (l1.next != null)
                l1.next.val += 1;
            else l1.next = new ListNode(1);
        r %= 10;
        if (l1.next != null && l2.next != null)
            return new ListNode(r, AddTwoNumbers(l1.next, l2.next));
        else if (l1.next != null)
            return new ListNode(r, AddTwoNumbers(l1.next, new ListNode()));
        else if (l2.next != null)
            return new ListNode(r, AddTwoNumbers(new ListNode(), l2.next));
        else return new ListNode(r);
    }
}

//You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

//You may assume the two numbers do not contain any leading zero, except the number 0 itself.

//Example:

//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
//Explanation: 342 + 465 = 807.