using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Plots
{
    public class MathClass
    {
        public static List<Plots> plots = new List<Plots>();
        public static List<string> Overlaps = new List<string>();

        public void CreatePlot(string[] ArrayOfPlotPoints)
        {
            List<int> PlotPoints = new List<int>();
            for (int i = 0; i < ArrayOfPlotPoints.Length; i++)
            {
                PlotPoints.Add(Convert.ToInt32(ArrayOfPlotPoints[i]));
            }
            int X1Coord = (PlotPoints[0] + PlotPoints[3]);
            int Y1Coord = (PlotPoints[1] + PlotPoints[2]);
            Plots plot = new Plots(PlotPoints[0], PlotPoints[1], PlotPoints[2], PlotPoints[3], X1Coord, Y1Coord);
            plots.Add(plot);
        }

        public List<string> GetOverlappedPlots()
        {
            for (int i = 0; i < plots.Count; i++)
            {
                for (int j = 0; j < plots.Count; j++)
                {
                    if (i == j)
                    {

                    }
                    else
                    {
                        if (!(plots[i].X > plots[j].x1 || plots[i].x1 < plots[j].X || plots[i].Y > plots[j].y1 || plots[i].y1 < plots[j].Y))
                        {
                            string OverlappedPlotCoordinate = string.Format("{0},{1},{2},{3}", plots[i].X, plots[i].Y, plots[i].Height, plots[i].Width);
                            if (!Overlaps.Contains(OverlappedPlotCoordinate))
                            {
                                Overlaps.Add(OverlappedPlotCoordinate);
                            }
                        }
                        else
                        {
                            string NoOverlaps = string.Format("No plots are overlapping");
                            Overlaps.Add(NoOverlaps);
                        }
                    }
                }

            }
            return Overlaps;
        }

        public void FindPlotPerimeter()
        {
            //int width = plots.Width;
            //int height = plots.Height;
            //int perimeter;
            string path = "total_fencing.txt";
            List<int> plotPerimeter = new List<int>();

            //perimeter = 2 * (width + height);

            using(StreamWriter writer = new StreamWriter(path))
            {
                foreach(int item in plotPerimeter)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }

        }
        public void FindOverallPerimeter()
        {
            //int overallPerimeter;
        }
        public void FindPlotArea()
        {
            //int area;
            //area = width * height;
        }

    }
}
