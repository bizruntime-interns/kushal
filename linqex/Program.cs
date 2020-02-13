using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<string> stringList = new List<string>() {
            "Bizrntime IT services",
            "innovaters bay",
            "infoscaters IT services",
            "MVC IT " ,
            "Qualitas pvt ltd"
        };


        var result = from s in stringList
                     where s.Contains("IT")
                     select s;

        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }
}