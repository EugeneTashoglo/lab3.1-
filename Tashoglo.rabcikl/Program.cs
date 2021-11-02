using System;

namespace Tashoglo.rabcikl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число N:");
                int N = int.Parse(Console.ReadLine());
                for (int i = 10; i <= N; i++)
                {
                    int m = i;
                    int max = int.MaxValue;
                    while(m!=0)
                    {
                        if (m % 10 < max) max = m % 10;
                        m /= 10;
                    }
                    Console.WriteLine(i+" "+max);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
