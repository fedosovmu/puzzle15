using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle15
{
    interface IPlayable
    {
        int Size
        {
            get;
        }
        int this[int x, int y]
        {
            get;
            set;
        }
        void Randomize();
        bool IsFinished
        {
            get;
        }
        bool Shift(int value);
    }
}
