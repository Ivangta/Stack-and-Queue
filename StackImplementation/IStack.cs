using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementation
{
    interface IStack
    {
        void Push(int item);
        int Pop();
        int Peek();
    }
}
