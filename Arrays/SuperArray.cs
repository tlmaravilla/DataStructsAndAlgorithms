using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class SuperArray
    {
        private int[] items;
        private int count;

        public SuperArray(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            // If the array is full, resize
            IsResizeRequired();

            // Get the current index and increment it, then add item
            items[count++] = item;
        }

        public void Print()
        {
            foreach (var item in items)
            {
                if(item > 0)
                    Console.WriteLine(item);
            }
        }

        private void IsResizeRequired()
        {
            if(items.Length == count)
            {
                var resize = new int[count * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    resize[i] = items[i];
                }
                items = resize;
            }
        }
    }
}
