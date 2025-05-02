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
public class ReverseLinkedList {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;

        var prevNode = head;
        var currentNode = prevNode.next;
        prevNode.next = null;

        ListNode temp= null;
        while(currentNode != null)
        {
            temp = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = temp;
        }
        return prevNode;
    }
}