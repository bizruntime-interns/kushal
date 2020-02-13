using System;
using System.Threading.Tasks;
using System.Threading;

namespace async1
{

    class Program
    {
       
        private static int PerformLoop()
        {
            Task task = Task.Run(() =>
            {
                int a = 0;
                for (a = 0; a <= 100; a++) { }
                Console.WriteLine("{0} loop iterations ends", a);
            });
            return a;
        }
        static int PerformAdd(int a, int b)
        {
            int z = a + b;
            return z;
        }
        static int PerformSub(int a, int b)
        {
            int z = a - b;
            return z;
        }
        static void Main(string[] args)
        {
            int addidtion = PerformAdd(10,5);
            Console.WriteLine("The Sum is:" + addidtion);
            int result = PerformLoop();
            Console.WriteLine("The result is :" + result);
            int subtraction = PerformSub(10,5);
            Console.WriteLine("The result is :" + subtraction);
        }
    }
}