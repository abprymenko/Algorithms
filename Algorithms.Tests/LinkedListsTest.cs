namespace Algorithms.Tests;

using Algorithms.Models;
using Algorithms.TwoPointers.BothSameDirection;

#region LinkedListsTest
internal class LinkedListsTest
{
    #region Private : Fields
    private Node? _tail;
    private Node? _head;
    #endregion

    #region Setup
    [SetUp]
    public void Setup()
    {
        _tail = new Node
        {
            Data = 5,
            Next = null
        };
        _head = new Node
        {
            Data = 1,
            Next = new Node
            {
                Data = 2,
                Next = new Node
                {
                    Data = 3,
                    Next = new Node
                    {
                        Data = 4,
                        Next = _tail
                    }
                }
            }
        };
    }
    #endregion

    #region Public : Methods
    [Test]
    public void HasCycle_False_Test()
    {
        try
        {
            var arrange = false;
            var act = LinkedLists.HasCycle(_head);
            Assert.That(act, Is.EqualTo(arrange));
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
    [Test]
    public void HasCycle_True_Test()
    {
        try
        {
            var arrange = true;
            _tail?.Next = _head;
            var act = LinkedLists.HasCycle(_head);
            Assert.That(act, Is.EqualTo(arrange));
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
    [Test]
    public void FindMiddleList_Test()
    {
        try
        {
            var arrange = 3;
            var act = LinkedLists.FindMiddleList(_head);
            Assert.That(act?.Data, Is.EqualTo(arrange));
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
    [Test]
    public void FindMiddleList_ThrowsException_Test()
    {
        try
        {
            _tail?.Next = _head;
            var act = LinkedLists.FindMiddleList(_head);
            Assert.Fail($"Expected exception was not thrown. act: {act?.Data}");
        }
        catch (Exception ex)
        {
            Assert.Pass(ex.Message);
        }
    }
    #endregion
}
#endregion