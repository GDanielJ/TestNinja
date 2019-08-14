using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowArgumentNullException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ArgIsValid_AddObjToStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_NoObjInStack_ReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();

            var result = stack.Count;

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Count_OneObjInStack_ReturnOne()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            var result = stack.Count;

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Pop_NoObjInStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObj_ReturnObjOnTopOfStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithAFewObj_ObjIsRemoved()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_NoObjInStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithAFewObj_ReturnObjOnTopOfStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Assert.That(() => stack.Peek(), Is.EqualTo("c"));
        }
    }
}
