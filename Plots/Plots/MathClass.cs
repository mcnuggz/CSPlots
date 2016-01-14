﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Plots
{
    public class MathClass
    {   
        public static List<string> Overlaps = new List<string>();
        public static List<Plots> plots = new List<Plots>();
        public static List<int> plotPerimeter = new List<int>();

        public int width;
        public int height;

        private int FindWidth()
        {
            foreach (var item in plots)
            {
                width = item.Width;
            }
            return width;
        }

        private int FindHeight()
        {
            foreach (var item in plots)
            {
                height = item.Height;
            }
            return height;
        }

        public void ReadLines(string FileName)
        {
            foreach (string plot in File.ReadAllLines(FileName))
            {
                string[] coords = plot.Split(',');
                CreatePlot(coords);
            }
        }

        public void CreatePlot(string[] ArrayOfPlotPoints)
        {
            List<int> PlotPoints = new List<int>();
            for (int i = 0; i < ArrayOfPlotPoints.Length; i++)
            {
                PlotPoints.Add(Convert.ToInt32(ArrayOfPlotPoints[i]));
            }
            int X1Coord = (PlotPoints[0] + PlotPoints[3]);
            int Y1Coord = (PlotPoints[1] + PlotPoints[2]);
            Plots plot = new Plots(PlotPoints[0], PlotPoints[1], PlotPoints[2], PlotPoints[3]);
            plots.Add(plot);
        }

        public void GetOverlappedPlots()
        {
            string path = "overlapping_plots.txt";
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
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string item in Overlaps)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }
        }
        public void FindPlotPerimeter()
        {
            FindWidth();
            FindHeight();
            int perimeter;
            string path = "total_fencing.txt";

            foreach (var item in plots)
            {
                perimeter = item.Height + item.Width * 2;
                plotPerimeter.Add(perimeter);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var item in plotPerimeter)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
            }
        }
        public void FindOverallPerimeter()
        {
            //int overallPerimeter;
            int MaxX = plots.Max(maxX => maxX.x1);
            int MaxY = plots.Max(maxY => maxY.y1);
            int MinX = plots.Min(minX => minX.X);
            int MinY = plots.Min(minY => minY.Y);
            string path = "total_fencing.txt";

            using(StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("{0},{1} and {2},{3}", MinX, MinY, MaxX, MaxY);
            }
        }
        public void FindPlotArea()
        {
            FindHeight();
            FindWidth();
            int area;
            int totalArea = 0;
            float bottleCount = 0;
            string path = "total_fertilizer.txt";

            foreach (var item in plots)
            {
                area = item.Width * item.Height;
                totalArea += area;
                bottleCount = totalArea / 2;
            }
            
            using(StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Total area: " + totalArea);
                writer.WriteLine("Fertilizer bottles needed: " + bottleCount);
            }

        }
        public void Rotate90()
        {
            // x1 = x + height  - width 
        }
        public void Rotate180()
        {
            //x1 = x - 2(width)
        }
        public void Rotate270()
        {
            Rotate90();
            Rotate180();
        }
    }
}
