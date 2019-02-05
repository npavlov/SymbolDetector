using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolDetector.Models
{
    interface ISymbolFinder
    {
        string[] FindPatterns(ISymbol symbol, int[,] data);
    }
}
