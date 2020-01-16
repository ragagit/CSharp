using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> func1 = x => x * x + 2;
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("x = {0}", func1(5 + i));
            }

            int y = 8;
            Func<int> func2 = () => y * 2 + 8;

            for (int i = 0; i < 5; i++)
            {
                y = func2();
                Console.WriteLine("y is {0}", y);
            }
        }
    }
}
