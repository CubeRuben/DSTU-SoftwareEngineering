using System;

namespace SimpleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 2; a <= 6; a++) 
            {
                Console.WriteLine($"Таблица умножения для числа {a}");

                for (int b = 2; b < 10; b++) 
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }
        }
    }
}
