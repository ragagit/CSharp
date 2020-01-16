using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 7, 2, 23, 45, 12 };

            IEnumerable<int> evenNums =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            foreach (int i in evenNums)
                Console.WriteLine(i);

            IEnumerable<int> evenNums2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);
            IEnumerable<int> evenStored = evenNums2.ToArray();

            numbers[2] = 14;
            numbers[5] *= 2;

            Console.WriteLine("Deferred Execution:");
            foreach (int i in evenNums2)
                Console.WriteLine(i);

            Console.WriteLine("Immediate Execution:");
            foreach (int i in evenStored)
                Console.WriteLine(i);
        }
    }
}
