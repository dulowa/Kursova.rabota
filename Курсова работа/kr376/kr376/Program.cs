using System;

namespace kr376
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Да се въведе произволно число k и произволен брой ненулеви числа! ");
            Console.WriteLine("За край на въвеждането въведете 0 ! ");
            double x, s = 0; int br = 0;
            do
            {
                Console.Write("Въведи число: ");
                x = double.Parse(Console.ReadLine());
                s+= x; //s=s+x
                if (x!= 0) br++;
            } while (x != 0);
            if (br > 0)
            {
                Console.WriteLine("Сумата на числата: " + s);
                Console.WriteLine("Средноаритметично: " + s / br);
            }
        }
    }
}
