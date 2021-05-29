using System;
using System.Collections.Generic;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            H<int> heap = new H<int>();

            heap.AddKey(2);
            heap.AddKey(4);
            heap.AddKey(6);
            heap.PopMax();

            heap.AddKey(2);
            heap.AddKey(4);
            heap.AddKey(6);
            heap.PopMax();
            heap.AddKey(2);
            heap.AddKey(4);
            heap.AddKey(6);
            heap.PopMax();
            heap.AddKey(4);
            heap.AddKey(6);
            heap.AddKey(4);
            heap.AddKey(6);
            heap.AddKey(4);
            heap.AddKey(6);

            Console.WriteLine($"Capacity is {heap.Capacity} and count is {heap.Count}");

            Console.WriteLine($"{heap.GetMax()}");
            Console.ReadLine();


        }
        
    }
}
