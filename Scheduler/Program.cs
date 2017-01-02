using System;
using System.Threading;
using Resources;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("web job started");
            while (true)
            {
                Console.WriteLine("Hey from job");
                Thread.Sleep(1000);
            }
        }
    }
}
