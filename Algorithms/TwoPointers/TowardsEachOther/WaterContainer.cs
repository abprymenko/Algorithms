namespace Algorithms.TwoPointers.TowardsEachOther;

public class WaterContainer
{
    /*
    Container With Most Water
    Condition: You are given an array of integers height of length $N$, where each number represents the height of a vertical line,
    plotted on the $X$ coordinate axis (the index is the position on the $X$ axis, and the value is the height).
    You need to find two lines that, together with the $X$ axis, form a container that contains the largest amount of water.
    The method should return this maximum area (water volume).
    Important: The container cannot be tilted, the water is poured to the level of the lower of the two selected lines.
    Optimization condition: The array can be huge. A head-on solution with two for loops will give an efficiency of $O(N^2)$,
    which will overwhelm tests on large data. You need to solve in $O(N)$ in one pass and $O(1)$ in memory.
    Example: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
    If we take the line at index 1 (height 8) and the line at index 8 (height 7):
    The distance between them (bottom width): $8 - 1 = 7$.
    The height of the water (along the minimum line): $\min(8, 7) = 7$.
    The area (volume): $7 \times 7 = 49$.
    (This is the maximum result for this array).
    */
    public static (long area, int index1, int index2) ContainerWithMostWater(int[] array)
    {
        if (array is not { Length: > 0})
            return (-1, -1, -1);
        var left = 0;
        var right = array.Length - 1;
        var area = 0L;
        var index1 = 0;
        var index2 = 0;
        while (left < right)
        {
            if (array[left] <= 0)
            {
                left++;
                continue;
            }
            if (array[right] <= 0)
            {
                right--;
                continue;
            }
            var width = right - left;
            var height = int.Min(array[left], array[right]);
            var currentArea = (long)width * height;
            if(area < currentArea)
            {
                area = currentArea;
                index1 = left;
                index2 = right;
            }
            if(array[left] < array[right])
            {
                var currentHeight = array[left];
                left++;
                while (left < right && array[left] <= currentHeight)
                {
                    left++;
                }
            }
            else
            {
                var currentHeight = array[right];
                right--;
                while(left < right && array[right] <= currentHeight)
                {
                    right--;
                }
            }
        }
        return (area, index1, index2);
    }
}