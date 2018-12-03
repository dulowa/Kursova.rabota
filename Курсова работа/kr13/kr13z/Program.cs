using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr13z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете седемцифрено положително число!");
            string chislo = Console.ReadLine();
            chislo = chislo.Trim();
            if (chislo.Length != 7)
            {
                Console.WriteLine("Некоректна дължина! ");
                Console.ReadKey(true); Environment.Exit(0);
            }
            int k = Int32.Parse(Console.ReadLine());
            int a = k / 1000000;
            int b = (k / 100000) % 10;
            int c = (k / 10000) % 10;
            int d = (k / 1000) % 10;
            int e = (k / 100) % 10;
            int f = (k / 10) % 10;
            int g = k % 10;
            Console.WriteLine();
            Console.WriteLine("Отляво-надясно = {0}{1}{2}{3}{4}{5}{6}", a, b, c, d, e, f, g);
            Console.WriteLine();
            Console.WriteLine("Отдясно-наляво = {6}{5}{4}{3}{2}{1}{0}", a, b, c, d, e, f, g);
            Console.WriteLine();
            Console.WriteLine("k- та цифра е {0} ", Convert.ToString(d));
        }
    }
}
