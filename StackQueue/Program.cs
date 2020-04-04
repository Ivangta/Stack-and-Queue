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


            //int[] array = new int[5];

            //int item;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    item = int.Parse(Console.ReadLine());
            //    Enqueue(i, item, array);
            //}


            //int[] arrayNew = new int[array.Length - 1];

            //Dequeue(array, arrayNew);

            //Peek(array);

        }


        //static public void Enqueue(int i, int item, int[] array)
        //{
        //    array[i] = item;
        //}

        //static public void Dequeue(int[] array, int[] arrayNew)
        //{
        //    for (int i = 1, j = 0; i < array.Length; i++, j++)
        //    {
        //        arrayNew[j] = array[i];
        //    }
        //}

        //static public void Peek(int[] array)
        //{
        //    Console.WriteLine(array[0]);
        //}
    }

    
}

