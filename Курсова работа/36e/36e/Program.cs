using System;
namespace _36e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числа: ");
            Console.WriteLine();
            Console.WriteLine("Въведете първото число");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете второто число");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете третото число");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (x > 0 || y > 0 || z > 0)
            {
                Console.WriteLine("Има положително число!");
            }
            else Console.WriteLine("Няма нито едно положително число! ");
        }
    }
}
