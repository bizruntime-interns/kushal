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

        class ReadFile
        {
            

            public void DataRead()
            {
                StreamReader sr = new StreamReader("C:/Users/kushal/source/repos/filewrite/outputfile.txt");

                Console.WriteLine("Content of the file is :");
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                   

                }
                Console.ReadLine();
                sr.Close();
            }
        }
        static void Main(string[] args)
        {
            WriteToFile wr = new WriteToFile();
            wr.DataWrite();
            Console.ReadKey();

            ReadFile sr = new ReadFile();
            sr.DataRead();
            
        }
    }
}
