using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStackLib
{
    class MyStack
    {
        private int[] array;
        public int Size { get; private set; }
        public int Length { get; private set; }

        public MyStack(int length)
        {
            Length = length;
            array = new int[length];
        }

        public void Push(int value)
        {
            if (Size < Length)
            {
                array[Size] = value;
                Size++;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public int Pop()
        {
            Size--;
            return array[Size];
        }
    }
}
