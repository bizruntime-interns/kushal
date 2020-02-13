using System;
namespace ConsoleApp1
{
    class Methods
    {
      
        static int Sum(int x, int y)
        {

           
            int a = x;
            int b = y;

           
            int result = a + b;

            return result;
        }

        static void Main(string[] args)
        {
            int a = 12;
            int b = 23;

           
            int c = Sum(a, b);

            
            Console.WriteLine("The Value of the sum is " + c);
        }
    }
}
