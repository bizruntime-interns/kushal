
using System;

namespace methodoverloading
{
    class Operator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }


        public static void Main(String[] args)
        {


            Operator obj = new Operator();

            int sum1 = obj.Add(1, 2);
            Console.WriteLine("sum of the two integer value : " + sum1);

            int sum2 = obj.Add(1, 2, 3);
            Console.WriteLine("sum of the three integer value : " + sum2);


        }
    }
}
