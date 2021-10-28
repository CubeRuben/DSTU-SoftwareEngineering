using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");

        int dayNumber;

        while (!int.TryParse(Console.ReadLine(), out dayNumber)) { Console.WriteLine("Ошибка: Неверный формат числа"); }

        string dayName = GetDayName(dayNumber);

        if (dayName == string.Empty)
        {
            Console.WriteLine("Ошибка: День недели не определён");
        }
        else
        {
            Console.WriteLine(dayName);
        }
    }

    static string GetDayName(int dayNumber)
    {
        switch ((dayNumber - 1) % 7)
        {
            case 0: return "Понедельник";
            case 1: return "Вторник";
            case 2: return "Среда";
            case 3: return "Четверг";
            case 4: return "Пятница";
            case 5: return "Суббота";
            case 6: return "Воскресенье";
        }

        return "";
    }
}