namespace Algorithms.TwoPointers.BothSameDirection;

using Models;

#region LinkedLists
public class LinkedLists
{
    #region Linked List Cycle
    /*
    Determine whether there is a loop in a linked list (when an element refers to one of the previous ones).
    How it works: If there is a loop, then the fast pointer will sooner or later catch up with the slow one 
    (like on a circular track in running). If the fast one reaches null, there is no loop.
     */
    public static bool HasCycle(Node? head)
    {
        if(head == null || head.Next == null) 
            return false;
        var slow = head;
        var fast = head.Next;
        while (slow != null && fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if (slow == fast)
                return true;
        }
        return false;
    }
    #endregion

    #region Middle of a Linked List
    /*
    Find the Middle of a Linked List (Find the Middle of a List in One Pass):
    How it Works: While fast takes two steps, slow takes one.
    When fast reaches the end of the list, slow will be right in the middle! Memory $O(1)$.
     */
    public static Node? FindMiddleList(Node? head)
    {
        if (head == null || head.Next == null)
            return head;
        var slow = head;
        var fast = head;
        while(slow != null && fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if (slow == fast)
            {
                throw new ArgumentException("Linked list contains a cycle. Middle cannot be determined.");
            }
        }
        return slow;
    }
    // Find First Node of Loop  -> Node? CycleStart(Node head)
    // Remove Loop from Linked List  -> void RemoveLoop(Node head)
    // Find Length of Loop in Linked List  -> int CountNodesInLoop(Node head)
    // Remove Node -> Node? RemoveNode(Node head, int value)
    #endregion
}
#endregion