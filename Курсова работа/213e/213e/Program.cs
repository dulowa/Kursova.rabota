using System;
namespace _213e
{
    class Program
    {
        static void Main(string[] args)
        {
            float s = 0;
            int i;
            for (i = 49; i > 0; i--)
            {
                Console.WriteLine(Math.Sqrt(s + i));
                Console.WriteLine(s);
            }
        }
    }
}
