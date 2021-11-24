using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1. Базовый уровень 20 вариант
            try
            {
                Console.WriteLine("Введите N:");
                int N = int.Parse(Console.ReadLine());
                for (int i = 10; i < N; i++)
                {
                    int m = i;
                    int min = int.MaxValue;
                    while (m != 0)
                    {
                        if (m! / 2 < min) min = m! / 10;
                        m /= 5;
                    }
                    Console.WriteLine(i + " " + min);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
