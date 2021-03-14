using System;

namespace TestTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            print_threadid("0");
            new ThreadTimer().run("1", 1000);
            new SystemTimer().run("2", 2000);

            Console.WriteLine($"End to Enter");
            Console.ReadLine();
        }

        static void print_threadid(string id)
        {
            Console.WriteLine($"id: {id} threadId: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
