using System;
using System.IO;

namespace filewrite
{
    class Program
    {
        class WriteToFile
        {
            private const string Path = "C:/Users/kushal/source/repos/filewrite/outputfile.txt";

            public void DataWrite()
            {
                StreamWriter sw = new StreamWriter(Path);

                Console.WriteLine("enter the text that you want to save ");
                String str = Console.ReadLine();

                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
            }

        }

      
        static void Main(string[] args)
        {
            WriteToFile wr = new WriteToFile();
            wr.DataWrite();
            Console.ReadKey();

       

        }
    }
}
