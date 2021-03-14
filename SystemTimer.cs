using System;
using System.Timers;

namespace TestTimer
{
    public class SystemTimer
    {
        private string id = "";
        public void run(string id, int msec)
        {
            this.id = id;
            Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(timer_callback);
            timer.Interval = msec;
            timer.Start();
        }

        public void timer_callback(object sender, ElapsedEventArgs e)
        {
            print_threadid(this.id);
        }

        static void print_threadid(string id)
        {
            Console.WriteLine($"id: {id} threadId: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        }
    }
}