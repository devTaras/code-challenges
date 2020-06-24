public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        ListNode current = null;
        while (l1 != null || l2 != null)
        {
            if (l1 != null && l2 != null)
            {
                if (current == null)
                {
                    if (l1.val <= l2.val)
                    {
                        current = new ListNode(l1.val);
                        result = current;
                        l1 = l1.next;
                    }
                    else
                    {
                        current = new ListNode(l2.val);
                        result = current;
                        l2 = l2.next;
                    }
                }
                else
                {
                    if (l1.val <= l2.val)
                    {
                        current.next = new ListNode(l1.val);
                        l1 = l1.next;
                        current = current.next;
                    }
                    else
                    {
                        current.next = new ListNode(l2.val);
                        l2 = l2.next;
                        current = current.next;
                    }
                }
            }
            else if (l1 != null)
            {
                if (current == null)
                {
                    current = new ListNode(l1.val);
                    result = current;
                    l1 = l1.next;
                }
                else
                {
                    current.next = new ListNode(l1.val);
                    l1 = l1.next;
                    current = current.next;
                }
            }
            else //l2!=null
            {
                if (current == null)
                {
                    current = new ListNode(l2.val);
                    result = current;
                    l2 = l2.next;
                }
                else
                {
                    current.next = new ListNode(l2.val);
                    l2 = l2.next;
                    current = current.next;
                }
            }

        }

        return result;
    }

}

//Merge two sorted linked lists and return it as a new sorted list.The new list should be made by splicing together the nodes of the first two lists.

//Example:

//Input: 1->2->4, 1->3->4
//Output: 1->1->2->3->4->4