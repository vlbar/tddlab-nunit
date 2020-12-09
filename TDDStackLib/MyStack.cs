using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStackLib
{
    class MyStack
    {
        public int Size { get; private set; }

        public int Length { get; private set; }

        public MyStack(int length)
        {
            Length = length;
        }

        public void Push(int value)
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }
    }
}
