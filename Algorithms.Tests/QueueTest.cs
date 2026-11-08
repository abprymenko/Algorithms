namespace Algorithms.Tests;

using Algorithms.DataStructures;

internal class QueueTest
{
    [SetUp]
    public void Setup()
    {

    }
    [TestCaseSource(nameof(DataInt))]
    public void FirstUniqueChar_Test(string word, int arrange)
    {
        var act = MyQueue.FirstUniqueChar(word);
        Assert.That(act, Is.EqualTo(arrange));
    }
    private static IEnumerable<TestCaseData> DataInt
    {
        get
        {
            yield return new TestCaseData(default(string), -1).SetName("Null");
            yield return new TestCaseData(string.Empty, -1).SetName("Empty");
            yield return new TestCaseData("loeleeoe", -1).SetName("None");
            yield return new TestCaseData("loveleetcode", 2).SetName("UChar");
        }
    }
}