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
            plotMath.Rotate90(MathClass.plots);
            plotMath.Rotate90(plotMath.Rotate180(MathClass.plots));
            plotMath.Rotate180(MathClass.plots);
            //plotMath.Rotate270(MathClass.plots);

        }

    }
}
