using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(50);
            obj.Add("Dog");
            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
