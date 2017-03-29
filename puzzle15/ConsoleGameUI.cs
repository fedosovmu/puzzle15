using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle15
{
    class ConsoleGameUI
    {
        private IPlayable iPlayable;
        public ConsoleGameUI(IPlayable iPlayable)
        {
            this.iPlayable = iPlayable;
            reDraw();
        }

        

        private void reDraw()
        {
            Console.Clear();
            for (int i = 0; i < iPlayable.Size; i++)
            {
                for (int j = 0; j < iPlayable.Size; j++)
                    Console.Write(String.Format("{0,3}", iPlayable[i, j]));
                Console.WriteLine();
            }

        }
    }
}
