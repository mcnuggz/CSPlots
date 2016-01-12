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
        protected int x;
        protected int y;
        protected int width;
        protected int height;

        string plot = File.ReadAllText("Plot.txt");
        public int[] plotInts;

        public void Print()
        {

            foreach (var item in plotInts)
            {
                Console.Write(item.ToString() + " ");
            }

        }

        public void ConvertToInt()
        {
            string[] tokens = plot.Split(',');

            plotInts = Array.ConvertAll<string, int>(tokens, int.Parse);

        }

    }
}
