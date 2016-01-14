using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Plots
{
    public class Plots
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int x1;
        public int y1;

        public Plots(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            x1 = x + width;
            y1 = y + height;            
        }
    }
}
