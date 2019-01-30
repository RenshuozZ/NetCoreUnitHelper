using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);

             Test();

            Console.WriteLine(" ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            Console.ReadKey();
        }

        static async void Test()
        {
            await Task.Run(() =>
            {
                Console.WriteLine(" ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            });
            Console.WriteLine(" ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
        }
    }

}
