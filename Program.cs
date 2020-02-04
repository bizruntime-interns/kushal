using System;

namespace branchloopex
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num=20;
            int result = 0;
            string  numbers = "";

            for (int i = 0; i <= num; i++)
            {
                if ( i % 3 ==0)
                {
                    result = result + i;
                }
                
            }
            
                Console.WriteLine("the sum is:" + result);
           
            

        }
        
    }
}
