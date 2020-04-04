using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StackQueue
{
    public class Queue : IQueue
    {
        private int?[] array = new int?[5];

        public int Dequeue()
        {
            var elementToReturn = array[0]; // Element to return
            MoveAllElementsToTheLeft();

            return elementToReturn ?? throw new Exception("Queue is empty!");
        }

        public void Enqueue(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    return;
                }
            }
            throw new Exception("The queue is full.");
        }

        public int Peek()
        {
            return array[0] ?? throw new Exception("Queue is empty.");
        }

        private void MoveAllElementsToTheLeft()
        {
            var subArray = array[1..]; // Subarray of all elements after the 1st one
            array = new int?[5]; // Clear the main array
            subArray.CopyTo(array, 0); //Move all elements from one array to the other
        }
    }

    
}
