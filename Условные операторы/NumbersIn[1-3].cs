using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите 3 числа: ");

        string numbers = Console.ReadLine();

        foreach (string number in numbers.Split(' '))
        {
            int convertedNumber = int.Parse(number);

            if (convertedNumber >= 1 && convertedNumber <= 3)
            {
                Console.Write($"{convertedNumber} ");
            }
        }
    }
}