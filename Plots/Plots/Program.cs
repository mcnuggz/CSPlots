using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Plots
{
    public class Program
    {
        static void Main(string[] args)
        {

            MathClass plotMath = new MathClass();

            plotMath.ReadLines("Plot.txt");
            plotMath.GetOverlappedPlots();
            plotMath.FindOverallPerimeter();
            plotMath.FindPlotPerimeter();
            plotMath.FindPlotArea();

        }

    }
}
