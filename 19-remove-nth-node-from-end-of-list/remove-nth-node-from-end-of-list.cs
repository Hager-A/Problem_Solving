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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (n == 0)
{
    return head;
}
ListNode temp = head;
int size = 0;
while (temp != null)
{
    temp = temp.next;
    size += 1;

}
if (size == 0)
{
    return null;
}
else if (size == 1 && n == 1) {
    return null;
}
int repea = size - 1 - n;
ListNode current = head;
if(repea<0){
   
   head=current.next;
    return head;
}

for (int i = 0; i <= repea; i++)
{
    if (i < repea)
    {
        current = current.next;

    }
    else
    {
        current.next = current.next.next;
    }
}

    return head;
        
    }
}