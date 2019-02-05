using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SymbolDetector.Models;

namespace SymbolDetector.Implementation
{
    class Reader : IReader
    {
        [Inject]
        public INormilizer Normilizer { get; set; }
        public int[,] GetData(string file)
        {
            var lines = File.ReadAllLines(file);

            lines = Normilizer.Normilize(lines);

            File.WriteAllLines("1.txt",lines);

            var xDimension = lines.Max(x => x.Length);

            var yDimension = lines.Length;

            var array = new int[yDimension, xDimension];

            for (int y = 0; y < yDimension; y++)
            {
                for (int x = 0; x < xDimension; x++)
                {
                    if (lines[y].Length - 1 < x)
                    {
                        array[y, x] = ' ';
                    }
                    else
                    {
                        array[y, x] = lines[y][x];
                    }
                }
            }

            return array;
        }
    }
}
