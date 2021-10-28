using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер класса: ");

        int gradeNumber;

        while (!int.TryParse(Console.ReadLine(), out gradeNumber)) { Console.WriteLine("Ошибка: Неверный формат числа"); }

        string gradeType = GetGradeType(gradeNumber);

        if (gradeType == string.Empty)
        {
            Console.WriteLine("Ошибка: Класс не определён");
        }
        else
        {
            Console.WriteLine(gradeType);
        }
    }

    static string GetGradeType(int gradeNumber)
    {
        switch (gradeNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                return "Младший класс";
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return "Средний класс";
            case 10:
            case 11:
                return "Старший класс";
        }

        return "";
    }
}