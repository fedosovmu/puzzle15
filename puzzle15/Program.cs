using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle15
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game2(6, 14, 0, 11, 13, 10, 1, 2, 9, 8, 7, 15, 5, 4, 3, 12);

            var a = new ConsoleGameUI(game);

            Console.ReadKey();
        }
    }
}
