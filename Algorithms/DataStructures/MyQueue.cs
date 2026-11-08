namespace Algorithms.DataStructures;

using Algorithms.Models;

#region MyQueue
public class MyQueue
{
    /*
    First Unique Character in a String
    This problem demonstrates the combination of a Queue (FIFO — First In, First Out) and a dictionary/frequency map for data flow analysis in a cool way.
    Condition: Given a string s. Find the first unique character (which occurs only once in the string) in it and return its index.
    If there is no such character, return -1.
    Example: s = "loveleetcode"
    The letter 'l' occurs 2 times.
    The letter 'o' occurs 2 times.
    The letter 'v' occurs 1 time. The index of 'v' is 2. The method should return 2.
    */
    
    public static int FirstUniqueChar(string s)
    {
        if (string.IsNullOrEmpty(s))
            return -1;
        Span<int> charsCounts = stackalloc int[256];
        var queue = new Queue<QueueItem>();
        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            charsCounts[ch]++;
            if(charsCounts[ch] == 1)
            {
                queue.Enqueue(new QueueItem(ch, i));
            }
            while (queue.Count > 0 && charsCounts[queue.Peek().Symbol] > 1)
            {
                queue.Dequeue();
            }
        }
        return queue.Count > 0 ? queue.Peek().Index : -1;
    }
}
#endregion