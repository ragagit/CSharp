using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/*
Threads
Enables perform concurrent processing operations
Instantiate a Thread object and call Start method 
IsAlive
It has. Name for debugging purposes.
Join blocks the calling thread until the other thread has completed.
ThreadState defines a set of all possible execution states for threads.

Passing Data to a Thread
With the Start method. 
Using lambda expressions

Background vs Foreground
By default threads you create explicitly are foreground threads. They keep
The app alive for as long as one of them is running. Once all the foreground threads finish
the app ends, any background thread if still running terminates abruptly.
There is IsBackground property.
Thread priority
Highest
AboveNormal
Normal
BelowNormal
Lowest


 */
namespace CSharpS7_6
{
    class Program
    {
        static void ThreadMethod(object threadNum){
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Thread #: {0} Loop: {1}", (int) threadNum, i);
                Thread.Sleep(5000);
                if ((int)threadNum == 3)
                    Thread.Sleep(20000);
            }
        }
        static void ThreadPoolMethod(object threadEvent)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Loop: {0}",  i);
                Thread.Sleep(5000);
            }
            ((ManualResetEvent)threadEvent).Set();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++) {
                int x = i;
                Thread t1 = new Thread(() => ThreadMethod(x));
                //t1.Start();
                if (i == 3)
                    t1.IsBackground = true;
                //Thread t1 = new Thread(ThreadMethod);
                //t1.Start(i); //Passing data to the thread

                t1.Priority = ThreadPriority.Highest;
            }

            ManualResetEvent[] events = new ManualResetEvent[4];
            for (int i = 0; i < 4; i++)
            {
                events[i] = new ManualResetEvent(false);
                ThreadPool.QueueUserWorkItem(ThreadPoolMethod, events[i]);
            }

            WaitHandle.WaitAll(events);
            //Console.WriteLine("The state of the thread is {0}", t1.ThreadState);
            //t1.Join();
            //Console.WriteLine("The state of the thread is {0}", t1.ThreadState);
            Console.WriteLine("The Main thread has ended.");
        }
    }
}
