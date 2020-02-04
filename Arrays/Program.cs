using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1

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
