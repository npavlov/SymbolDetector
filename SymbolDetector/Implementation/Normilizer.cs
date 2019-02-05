using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymbolDetector.Models;

namespace SymbolDetector.Implementation
{
    class Normilizer : INormilizer
    {
        public string[] Normilize(string[] data)
        {
            int yDim = data.Length;

            for (int y = 0; y < yDim; y++)
            {
                for (int x = 0; x < data[y].Length; x++)
                {
                    if (data[y][x] == '\t')
                    {
                        int k = 4 - x % 4;
                        var spaces = "";
                        while (k > 0)
                        {
                            spaces += " ";
                            k--;
                        }

                        var leftPart = data[y].Substring(0, x);
                        var rightPart = data[y].Substring(x+1, data[y].Length - x-1);

                        data[y] = leftPart + spaces + rightPart;
                    }
                }
            }

            return data;

        }
    }
}
