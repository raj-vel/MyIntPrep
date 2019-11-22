using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPrepProj.Classes
{
    interface IMyStack<T>
    {
        void Push(T element);
        T Pop();
        int MinValue();
        T Peek();
    }
}
