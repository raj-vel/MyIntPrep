using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPrepProj.Classes
{
    class MyStack<T> : IMyStack<T>
    {
        T[] stack;
        int minValue;
        int currentIndex;
        int capacity;

        public MyStack(int n)
        {
            capacity = n;
            stack = new T[capacity];
            currentIndex = 0;
        }

        public int MinValue()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T element)
        {
            if(currentIndex + 1 > capacity)
            {
                throw new ArgumentException("Exceeds limit");
            }
            else
            {
                stack[currentIndex++] = element;
                minValue = minValue < Convert.ToInt32(element) ? minValue : Convert.ToInt32(element);
            }
        }
    }
}
