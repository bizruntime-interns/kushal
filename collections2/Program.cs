
using System;
using System.Collections;

namespace collections2
{
    class Program
    {
        public static void Main()
        {

            Queue theQueue = new Queue();

            theQueue.Enqueue("PHP");
            theQueue.Enqueue("c#");
            theQueue.Enqueue("Perl");
            theQueue.Enqueue("Java");
            theQueue.Enqueue("C");

            Console.Write("Total number of elements present in the Queue are: ");

            Console.WriteLine(theQueue.Count);

            Console.WriteLine("Beginning Item is: " + theQueue.Peek());
        }
    }
}
