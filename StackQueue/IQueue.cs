using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public interface IQueue
    {
        public void Enqueue(int i, int item, int[] array)
        {
            array[i] = item;
        }

        public void Dequeue(int[] array)
        {
            int[] arrayNew = new int[array.Length - 1];

            for (int i = 1, j = 0; i < array.Length; i++, j++)
            {
                arrayNew[j] = array[i];
            }

        }

        public void Peek(int[] array)
        {
            Console.WriteLine(array[0]);
        }
    }
}
