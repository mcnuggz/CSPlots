using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Plots
{
    public class FileHandling
    {
        public static List<int[]> fileOutput;
        
        public static void ReadLines(string fileName)
        {
            fileOutput = new List<int[]>();
            foreach (string line in File.ReadAllLines(fileName))
            {
                fileOutput.Add(ConvertToInt(line));
            }
            
        }
        public static int[] ConvertToInt(string value)
        {
            string[] tokens = value.Split(',');
            int[] plotInts = Array.ConvertAll<string, int>(tokens, int.Parse);
            return plotInts;
        }
    }
}
