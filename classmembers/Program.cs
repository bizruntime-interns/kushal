using System;

namespace classmembers
{
    
   class Car
   {
            string color = "red";
            int maxSpeed = 200;

            static void Main(string[] args)
            {
                Car myObj = new Car();
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.maxSpeed);
            }
   }
   
    
}
