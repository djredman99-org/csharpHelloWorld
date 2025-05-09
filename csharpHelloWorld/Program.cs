using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpHelloWorld
{
    class Program
    {
        // This is the main entry point for the application.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        // This is a simple method to demonstrate a function in C#
        static int GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return "Hello";
        }
                        }


    }
}
