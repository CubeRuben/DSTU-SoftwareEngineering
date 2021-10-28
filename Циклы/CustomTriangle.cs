using System;

namespace SimpleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину катета: ");

            int lenght = int.Parse(Console.ReadLine());

            for (int x = 0; x < lenght; x++) 
            {
                for (int y = 0; y < lenght; y++) 
                {
                    Console.Write(((x == lenght - 1) || (y == 0) || (x == y)) ? "*" : " ");
                }

                Console.Write("\n");
            }
        }
    }
}
