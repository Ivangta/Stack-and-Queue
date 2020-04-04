using System;
using System.Linq;

namespace _02._Software_Academy_from_4th_April_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            int item;

            for (int i = 0; i < array.Length; i++)
            {
                item = int.Parse(Console.ReadLine());
                Enqueue(i, item, array);
            }


            int[] arrayNew = new int[array.Length - 1];

            Dequeue(array, arrayNew);

            Peek(array);

        }


        static public void Enqueue(int i, int item, int[] array)
        {
            array[i] = item;
        }

        static public void Dequeue(int[] array, int[] arrayNew)
        {
            for (int i = 1, j = 0; i < array.Length; i++, j++)
            {
                arrayNew[j] = array[i];
            }
        }

        static public void Peek(int[] array)
        {
            Console.WriteLine(array[0]);
        }
    }

    
}

