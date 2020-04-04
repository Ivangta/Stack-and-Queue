using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementation
{
    public class Stack : IStack
    {
        private int?[] array = new int?[8]; //Ето тук имам предвид 
        
        public void Push(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    return;
                }
            }
            throw new Exception("The stack is full.");
        }
        public int Pop()
        {

            //Option 1

            ////for (int i = array.Length - 1; i >= 0; i--)
            ////{
            ////    if (array[i] != null)
            ////    {
            ////        var temp = (int)array[i];
            ////        array[i] = null;
            ////        return temp;
            ////    }
            ////}
            ////throw new Exception("Stack is empty!");


            //Option 2

            int?[] arrayNew = new int?[array.Length - 1];

            for (int i = array.Length - 1, j = array.Length - 2; j >= 0; i--, j--)
            {
                if (array[i] != null)
                {
                    arrayNew[j] = array[i];
                }
                
            }
            for (int i = arrayNew.Length; i >= 0; i--)
            {
                if (arrayNew[i - 1] != null)
                {
                    return (int)arrayNew[i - 1];
                }
            }

             throw new Exception("Stack is empty!");
        }
        public int Peek()
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != null)
                {
                    return (int)array[i];
                }
            }
            throw new Exception("Stack is empty.");
        }
      
    }
}
