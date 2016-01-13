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
        public int x1 { get; set; }
        public int y1 { get; set; }

        public List<Plots> plotList;

        public Plots(int x, int y, int width, int height, int x1, int y1)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            x1 = x + height;
            y1 = y + width;            
        }
    }
}
