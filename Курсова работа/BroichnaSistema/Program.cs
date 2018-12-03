using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroichnaSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2083 в Двоична (2), Осмична (8) и в Шестнайсетична (16) бройна система");
            Console.WriteLine();
            Console.WriteLine("2083 в двоична е {0}.", Convert.ToString(2083, 2));
            Console.WriteLine();
            Console.WriteLine("2083 в осмична е {0}.", Convert.ToString(2083, 8));
            Console.WriteLine();
            Console.WriteLine("2083 в шестнайсетична {0}.", Convert.ToString(2083, 16));
        }
    }
}
