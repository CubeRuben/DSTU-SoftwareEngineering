using System;

namespace SimpleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите конечное число диапозона: ");

            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int summ = 0;

            for (int i = 2; i <= number; i++) 
            {
                if (i % 2 == 0) 
                {
                    count++;
                    summ += i;
                }
            }

            Console.WriteLine($"Количество парных чисел: {count}\nСумма парных чисел: {summ}");
        }
    }
}
