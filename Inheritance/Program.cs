using System;

namespace Inheritance
{ 
        class Base
        {
            public string name;
            public string subject;

            public void readers(string name, string subject)
            {
                this.name = name;
                this.subject = subject;
                Console.WriteLine("Myself: " + name);
                Console.WriteLine("My Favorite Subject is: " + subject);
            }
        }
        class Derived : Base
        {
            public Derived()
            {
                Console.WriteLine("internship");
            }
        }
        class Sudo
        {

            static void Main(string[] args)
            {

                Derived g = new Derived();
                g.readers("Kirti", "C#");
            }
        }
}