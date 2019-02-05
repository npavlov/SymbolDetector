using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SymbolDetector.Models;

namespace SymbolDetector.Implementation
{
    class SymbolFinder : ISymbolFinder
    {
        [Inject]
        public IMatrix Matrix { get; set; }
        [Inject]
        public IBorder Border { get; set; }
        public string[] FindPatterns(ISymbol symbol, int[,] data)
        {
            var result = new List<string>();

            var yDimension = data.GetLength(0);
            var xDimension = data.GetLength(1);

            var symbolData = symbol.GetSymbol;

            var ySymbolDim = symbolData.GetLength(0);

            var xSymbolDim = symbolData.GetLength(1);

            for (int y = 0; y < yDimension - ySymbolDim + 1; y++)
            {
                for (int x = 0; x < xDimension - xSymbolDim + 1; x++)
                {
                    var block = new int[ySymbolDim, xSymbolDim];
                    for (int y1 = 0; y1 < ySymbolDim; y1++)
                    {
                        for (int x1 = 0; x1 < xSymbolDim; x1++)
                        {
                            block[y1, x1] = data[y + y1, x + x1];
                        }
                    }

                    if (Matrix.Match(symbolData, block) &&
                        Border.MatchBorders(x, y, data, xDimension, xSymbolDim, ySymbolDim))
                    {
                        result.Add(symbol.ToString());
                    }
                }
            }

            return result.ToArray();
        }
        
    }
}
