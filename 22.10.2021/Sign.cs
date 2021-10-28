using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");

        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("Число равно нулю");
        }
        else if (number > 0)
        {
            Console.WriteLine("Число положительное");
        }
        else
        {
            Console.WriteLine("Число отрицательное");
        }
    }
}