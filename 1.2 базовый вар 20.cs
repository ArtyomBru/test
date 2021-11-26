using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите L:");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите I:");
            int I = int.Parse(Console.ReadLine());
            int W = L * (I * I) / 2;
            Console.WriteLine(W);
        }
    }
}
