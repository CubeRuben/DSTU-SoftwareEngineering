using System;

namespace SimpleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int answer = 0;

            for (int i = 1; i <= number; i++) 
            {
                answer += i;
            }

            Console.WriteLine(answer);
        }
    }
}
