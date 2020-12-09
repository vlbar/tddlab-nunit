using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStackLib
{
    [TestFixture]
    class MyStackTest
    {
        [Test]
        public void PushPopTest()
        {
            MyStack stack = new MyStack(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(8);

            Assert.AreEqual(8, stack.Pop());
            Assert.AreEqual(2, stack.Size);
        }
    }
}
