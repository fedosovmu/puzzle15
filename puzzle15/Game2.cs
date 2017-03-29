using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle15
{
    class Game2 : Game, IPlayable
    {
        public Game2(params int[] values) : base(values) { }



        public void Randomize()
        {
            Random rand = new Random();

            int count = rand.Next((int)Math.Pow(Size, 2), (int)Math.Pow(Size, 2) + 5);

            for (int i = 0; i < count; i++)
            {
                int x = rand.Next(0, Size - 1);
                int y = rand.Next(0, Size - 1);

                Rotate(x, y);
            }
        }



        private void Rotate(int x, int y)
        {
            int val = this[x, y];

            this[x, y] = this[x, y + 1];
            this[x, y + 1] = this[x + 1, y];
            this[x + 1, y] = val;
        }



        public bool IsFinished
        {
            get
            {
                for (int i = 0; i < values.Length; i++)
                    if (values[i] != (i + 1) % values.Length)
                        return false;
                return true;
            }
        }
    }
}
