namespace Algorithms.Tests;

using Algorithms.DataStructures;

public class StackTest
{
    [SetUp]
    public void Setup()
    {

    }
    [TestCaseSource(nameof(Data))]
    public void IsValid_Test(string parentheses, bool arrange)
    {
        var act = MyStack.IsValid(parentheses);
        Assert.That(act, Is.EqualTo(arrange));
    }

    private static IEnumerable<TestCaseData> Data
    {
        get
        {
            yield return new TestCaseData(default(string), false).SetName("Null");
            yield return new TestCaseData(string.Empty, false).SetName("Empty");
            yield return new TestCaseData("(]", false).SetName("IsNotValid");
            yield return new TestCaseData("([", false).SetName("IsNotValid");
            yield return new TestCaseData("([]({}))", true).SetName("IsValid");
            yield return new TestCaseData("()[]{}", true).SetName("IsValid");
            yield return new TestCaseData("{[]}", true).SetName("IsValid");
        }
    }
}
