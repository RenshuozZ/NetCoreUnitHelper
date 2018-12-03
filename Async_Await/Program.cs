using System;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = AddAsync(1, 2);

            //一直在干活
            Console.WriteLine($"result: {t.Result}");
            Console.Read();            
        }

        private static int Add(int n, int m)
        {
            return n + m;
        }

        public static async Task<int> AddAsync(int n, int m)
        {
            int val = await Task.Run(() => Add(n, m));

            return val;
        }
    }
}
