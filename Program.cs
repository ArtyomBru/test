using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {    //3.3
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double s = 0;
                for (int i = 1, h = 1; i < n; i++, h += 2)
                {
                    s += (1 + 2 / 1! * x / 2 + 5 / 2! * Math.Pow(x, 2) / 2 + 10 / 3! * Math.Pow(x, 3) / 2 * n);
                }
                Console.WriteLine("s={0:F2}",s);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
