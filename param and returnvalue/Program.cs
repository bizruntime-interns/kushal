using System;
namespace Factorial
{
    class FindFactorial
    {  
        static int factorial(int n)
        {
            int f = 1;
            

             while ( n <= 4)
            {
                f = f * n;
                n++;
            }
                return f;
        }

        
        static void Main(string[] args)
        {
            int p = 4;
            Console.WriteLine("Factorial is : " + factorial(p));
        }
    }
}
