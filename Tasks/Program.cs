using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Tasks

Thread limitations and Drawbacks
Although it is easy to pass data into a thread there is no easy way to return data.
The direct use of threads also has performance implications.

Tasks represent an asynchronous operation. They are more efficient and more scalable use
of resources and more programmatic control that threads.
Rich API
	Support waiting
	Cancellation
	Continuations
	Robust exception handling
	Detailed status
	Custom scheduling 

Thera re two types
Task
Task<TResult>

They have wait method.
Unhandled exceptions are propagated back to the joining thread.
*/
namespace CSharpS7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> Taskdel = (object obj) =>
            {
                int num = (int)obj;
                num = (int)Math.Pow(2, num);
                int sum = 0;

                for (int i = 0; i < num; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            };

            Func<object, int> Taskdel2 = (object obj) =>
            {
                int num = (int)obj;
                num = (int)Math.Pow(2, num);
                int sum = 0;

                for (int i = 0; i < num; i++)
                {
                    sum += i;
                }
                return sum;
            };

            Task t1 = new Task(Taskdel, 10);
            t1.Start();
            t1.Wait();

            Task<int> t2 = new Task<int>(Taskdel2, 2);



            Task<int> t3 = t2.ContinueWith(t => Taskdel2(t.Result));

            t2.Start();

            Console.WriteLine("T2 result = {0}", t2.Result);

            Console.WriteLine("T3 result = {0}", t3.Result);
        }
    }
}
