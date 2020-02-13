using System;

namespace async1
{
    
    class Program
    {
        static int PerformAdd(int a, int b)
        {
           int z=a+b;
           return z;  
        }
        static int PerformSub(int a, int b)
        {
           int z = a - b;
            return z;
        }
        static int PerformDiv(int a, int b)
        {
            int z = a / b;
            return z;
        }

        static void Main(string[] args)
        {
            int addition = PerformAdd(10,5);
            Console.WriteLine("The sum is :" + addition);
            int subtraction = PerformSub(10,5);
            Console.WriteLine("The result is :" +subtraction );
            int division = PerformDiv(10, 5);
            Console.WriteLine("Division result:" + division);
        }
    }
}
