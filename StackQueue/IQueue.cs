using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public interface IQueue
    {
        public void Enqueue(int item);
        public int Dequeue();
        public int Peek();
     
    }
}
