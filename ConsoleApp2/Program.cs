using System;
using ConsoleApp2.Homework1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int x = 3;
        static int y;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi! We're gonna do awesome stuff now :D");
            FirstHomeWork firstHomeWork = new FirstHomeWork();
            Console.WriteLine(value: x);
            Console.WriteLine(value: y);
            Console.ReadLine();
        }

        public int Adunare(int stuff)
        {
            return x + y;
            Console.WriteLine(stuff);
        }

        public int Scadere(int x, int y)
        {
            return x - y;
        }

        public int Wat(int Scadere, int Adunare)
        {
            int result = Scadere + Adunare;
            return result;
        }
    }
}
