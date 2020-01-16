using System;

namespace IntroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a string
            string input;
        

            //Hello World output
            Console.WriteLine("Hello World!");

            /*This will read user input
             * and then write this to the console*/
            //input = Console.ReadLine();

            //Console.WriteLine("This is your input: " + input);

            int x, y = 7;

            x = 3;

            Console.WriteLine("X is {1} and Y is {0}", x, y);

            Console.WriteLine("X+Y= {0}", (x + y));
            Console.WriteLine("Press enter to continue...");
            Console.Read();
        }
    }
}
