using System;
using System.Linq;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            IQueue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

        }
    }
}

