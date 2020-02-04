using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1
            /*
             * Create array wrapper that allows you to:
             * 1. insert numbers into array
             * 2. remove numbers from array
             * 3. print to console the array
             * 
             */

            var supArray = new SuperArray(5);
            supArray.Insert(10);
            supArray.Insert(20);
            supArray.Insert(30);
            supArray.Insert(40);
            supArray.Insert(50);
            supArray.Insert(60);
            supArray.Insert(70);
            supArray.Insert(80);

            supArray.Print();

            Console.WriteLine("Hello World!");
        }
    }
}
