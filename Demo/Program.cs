using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Test(new SmallCar());
            var list = new List<SmallCar>() { new SmallCar() };
            var Ilist = new List<ICar>();
            foreach (var item in list)
            {
                Ilist.Add(item);
            }
            //Program.TestList(list.CopyTo(new List<ICar>()));
        }

        public static void Test(ICar car)
        {
            car.ShowName();
        }

        public static void TestList(List<ICar> car)
        {
            foreach (var item in car)
            {
                item.ShowName();
            }
        }
    }
    public interface ICar
    {
        void ShowName();
    }

    public class SmallCar : ICar
    {
        public void ShowName()
        {
            Console.WriteLine("aa");
        }
    }
}
