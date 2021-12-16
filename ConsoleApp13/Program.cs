using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            double y = double.Parse(Console.ReadLine());
            if (y >= x+1 && y <= x+2 && y <= x - 1 && y >= x - 2) Console.WriteLine("Точка попадает в область");
            else Console.WriteLine("Точка не попадает в область");
        }
    }
}
