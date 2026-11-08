namespace Algorithms.Tests;

using Algorithms.TwoPointers.TowardsEachOther;

public class WaterContainer_Test
{
    [SetUp]
    public void Setup()
    {

    }
    [TestCaseSource(nameof(Heights))]
    public void ContainerWithMostWater_Test(int[] array, int arrangeArea)
    {
        var (actArea, index1, index2) = WaterContainer.ContainerWithMostWater(array);
        var arrayString = array == null ? "null" : array.Length == 0 ? "empty" : string.Join(", ", array);
        TestContext.Out.WriteLine($"{actArea} | {arrangeArea} | {arrayString} ({index1}, {index2})");
        Assert.That(actArea, Is.EqualTo(arrangeArea));
    }

    private static IEnumerable<TestCaseData> Heights
    {
        get
        {
            int[][] heights = [[1, 8, 6, 2, 7, 4, 8, 3, 5],
                               [1, 8, 6, 2, 5, 4, 8, 3, 7],
                               null,
                               Array.Empty<int>(),
                               [-1, -5, 8, 5, 3, 8, 9, 7, -6, -4],
                               [40, 49, -1, -1, 35]];
            var length = heights.GetLength(0) - 1;
            for (int i = 0; i < length; i++)
            {
                yield return new TestCaseData(heights[i], heights[length][i]).SetName("Args");
            }
        }
    }
}