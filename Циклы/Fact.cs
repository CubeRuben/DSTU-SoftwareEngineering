using System;

namespace SimpleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int answer = 1;

            while (number > 0) 
            {
                answer *= number;
                number--;
            }

            Console.WriteLine(answer);
        }
    }
}
