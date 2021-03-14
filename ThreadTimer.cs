using System;
using System.Threading;

namespace TestTimer
{
    public class ThreadTimer
    {
        public void run(string id, int msec)
        {
            var timer = new Timer(
                new TimerCallback(thread_timer_callback),
                id,
                0,
                msec
            );
        }

        static void thread_timer_callback(object o)
        {
            print_threadid(o.ToString());
        }

        static void print_threadid(string id)
        {
            Console.WriteLine($"id: {id} threadId: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}