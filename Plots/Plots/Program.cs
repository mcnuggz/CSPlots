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
            Plots plot = new Plots();
            plot.ConvertToInt();
            plot.Print();
            Console.ReadLine();
        }
    }
}
