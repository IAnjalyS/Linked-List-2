/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    //Time Complexity: O(n)
    //Space Complexity: O(1)
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null)
                return null;
            int lenA = 0, lenB = 0;
            ListNode curr = headA;
            while(curr != null)
            {
                curr = curr.next;
                lenA++;
            }
            curr = headB;
            while (curr != null)
            {
                curr = curr.next;
                lenB++;
            }
            while(lenA > lenB)
            {
                headA = headA.next;
                lenA--;
            }
            while (lenB > lenA)
            {
                headB = headB.next;
                lenB--;
            }
            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }
            return headA;
    }
}