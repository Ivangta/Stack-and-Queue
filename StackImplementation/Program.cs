using System;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack stack = new Stack();

            stack.Push(1);
            stack.Push(4);
            stack.Push(4);
            stack.Push(4);
            stack.Push(4);

            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Peek());
        }
    }
}
